/*
 * Libvirt-dotnet
 * 
 * Copyright 2020 IDNT (https://www.idnt.net) and Libvirt-dotnet contributors.
 * 
 * This project incorporates work by the following original authors and contributors
 * to libvirt-csharp:
 *    
 *    Copyright (C) 
 *      Arnaud Champion <arnaud.champion@devatom.fr>
 *      Jaromír Červenka <cervajz@cervajz.com>
 *
 * Licensed under the GNU Lesser General Public Library, Version 2.1 (the "License");
 * you may not use this file except in compliance with the License. You may obtain a 
 * copy of the License at
 *
 * https://www.gnu.org/licenses/lgpl-2.1.en.html
 * 
 * or see LICENSE for a copy of the license terms. Unless required by applicable 
 * law or agreed to in writing, software distributed under the License is distributed 
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express 
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace Libvirt
{
    /// <summary>
    /// Represents a libvirt domain
    /// </summary>
    public class LibvirtDomain : IDisposable
    {
        private readonly LibvirtConnection _conn;
        private readonly IntPtr _domainPtr;
        private XmlDocument _xmlDescription = null;
        private readonly object _xmlDescrLock = new object();
        private VirDomainInfo _virDomainInfo = null;

        internal LibvirtDomain(LibvirtConnection connection, Guid uniqueId, IntPtr domainPtr)
        {
            _conn = connection ?? throw new ArgumentNullException("connection");
            if (Guid.Empty.Equals(uniqueId))
                throw new ArgumentNullException("uniqueId");
            UniqueId = uniqueId;
            if (domainPtr == IntPtr.Zero)
                throw new ArgumentNullException("domainPtr");
            _domainPtr = domainPtr;
        }

        #region Console
        private bool WriteOfflineScreen(Stream stream, ImageFormat format)
        {
            using (var noSignalStream = typeof(LibvirtDomain).Assembly.GetManifestResourceStream("Libvirt.Resources.SystemOffline.png"))
                new Bitmap(noSignalStream).Save(stream, format);
            return true;
        }

        private bool WriteNoSignalScreen(Stream stream, ImageFormat format)
        {
            using (var noSignalStream = typeof(LibvirtDomain).Assembly.GetManifestResourceStream("Libvirt.Resources.NoVideoSignal.png"))
                new Bitmap(noSignalStream).Save(stream, format);
            return true;
        }

        private bool WriteNotSupoprtedScreen(Stream stream, ImageFormat format)
        {
            using (var noSignalStream = typeof(LibvirtDomain).Assembly.GetManifestResourceStream("Libvirt.Resources.NotSupported.png"))
                new Bitmap(noSignalStream).Save(stream, format);
            return false;
        }

        private bool WriteErrorScreen(Stream stream, ImageFormat format)
        {
            using (var noSignalStream = typeof(LibvirtDomain).Assembly.GetManifestResourceStream("Libvirt.Resources.InternalError.png"))
                new Bitmap(noSignalStream).Save(stream, format);
            return false;
        }

        public bool GetScreenshot(Stream stream, ImageFormat format)
        {
            if (!IsActive)
                return WriteOfflineScreen(stream, format);

            var streamPtr = NativeVirStream.New(_conn.ConnectionPtr, 0);
            if (streamPtr == IntPtr.Zero)
                return WriteErrorScreen(stream, format);

            Bitmap image = null;
            try
            {
                string mimeType = NativeVirDomain.GetScreenshot(_domainPtr, streamPtr, 0, 0);
                if (string.IsNullOrEmpty(mimeType))
                    return WriteNotSupoprtedScreen(stream, format);

                using (var ms = new MemoryStream())
                {
                    byte[] buffer = new byte[1024];

                    int rcvsize = 1;
                    while (rcvsize > 0)
                    {
                        rcvsize = NativeVirStream.Recv(streamPtr, buffer, 1024);
                        if (rcvsize > 0)
                            ms.Write(buffer, 0, rcvsize);
                    }

                    if (rcvsize < 0)
                        return WriteErrorScreen(stream, format);

                    ms.Seek(0, SeekOrigin.Begin);

                    switch (mimeType)
                    {
                        case "image/x-portable-pixmap":
                            image = GraphicsHelper.PortablePixmapToBitmap(ms, Color.Black);
                            break;
                        default:
                            return WriteErrorScreen(stream, format);
                    }
                }

                if (image == null)
                    return WriteNoSignalScreen(stream, format);

                image.Save(stream, format);
                return true;
            }
            finally
            {
                image?.Dispose();
                try { NativeVirStream.Finish(streamPtr); } catch (Exception) { }
                NativeVirStream.Free(streamPtr);
            }
        }

        public void SetConsolePassword(string password)
        {
            switch (DriverType)
            {
                case "qemu":
                case "kvm":
                    string result = null;
                    if (NativeVirQemu.MonitorCommand(_domainPtr, $"change vnc password \"{password}\"", ref result,
                        VirDomainQemuMonitorCommandFlags.VIR_DOMAIN_QEMU_MONITOR_COMMAND_HMP) < 0)
                        throw new LibvirtException($"SetConsolePassword failed: {result}");
                    Trace.WriteLine($"set console output: '{result}'");
                    break;
                default:
                    throw new LibvirtNotImplementedException();
            }
        }

        #endregion

        #region Properties
        /// <summary>
        /// Ptr
        /// </summary>
        public IntPtr Ptr { get { return _domainPtr; } }

        /// <summary>
        /// Unique domain identifier
        /// </summary>
        public Guid UniqueId { get; private set; }

        /// <summary>
        /// True if the domain is currently active (running).
        /// </summary>
        public bool IsActive { get { return NativeVirDomain.IsActive(_domainPtr) == 1; } }

        /// <summary>
        /// Retruns the hypervisors domain id or -1 if the domain is not running.
        /// </summary>
        public int Id { get { return NativeVirDomain.GetID(_domainPtr); } }

        /// <summary>
        /// The domains human readable name
        /// </summary>
        public string Name { get { return NativeVirDomain.GetName(_domainPtr); } }

        /// <summary>
        /// The type of operating system
        /// </summary>
        public string OSType { get { return NativeVirDomain.GetOSType(_domainPtr); } }

        /// <summary>
        /// Get domains runnig state
        /// </summary>
        public VirDomainState State
        {
            get
            {
                VirDomainState state = VirDomainState.VIR_DOMAIN_NOSTATE;
                int reason = 0;
                if (NativeVirDomain.GetState(_domainPtr, out state, out reason, 0) < 0)
                    return VirDomainState.VIR_DOMAIN_NOSTATE;
                return state;
            }
        }

        /// <summary>
        /// Returns the libvirt driver for this domain (qemu|kvm|esx|hyperv|...)
        /// </summary>
        public string DriverType
        {
            get { return XmlDescription.DocumentElement.Attributes["type"].Value; }
        }


        public VirDomainInfo GetInfo()
        {
            if (_virDomainInfo == null && NativeVirDomain.GetInfo(_domainPtr, (_virDomainInfo = new VirDomainInfo())) < 0)
            {
                _virDomainInfo = null;
                throw new LibvirtQueryException();
            }
            return _virDomainInfo;
        }

        #endregion

        #region Configuration
        public XmlDocument GetXmlDescription(VirDomainXMLFlags flags)
        {
            string xmlText = NativeVirDomain.GetXMLDesc(_domainPtr, flags);
            if (string.IsNullOrWhiteSpace(xmlText))
                throw new LibvirtQueryException();
            var doc = new XmlDocument();
            doc.LoadXml(xmlText);
            return doc;
        }
        public XmlDocument XmlDescription
        {
            get
            {
                XmlDocument document = null;
                lock (_xmlDescrLock)
                    document = _xmlDescription;

                if (document == null)
                {
                    lock (_xmlDescrLock)
                    {
                        if (_xmlDescription == null)
                        {
                            Trace.WriteLine($"Retrieving xml descriptor of domain {Name} (active={IsActive})");
                            VirDomainXMLFlags flags = 0;
                            if (!IsActive)
                                flags |= VirDomainXMLFlags.VIR_DOMAIN_XML_INACTIVE;
                            _xmlDescription = GetXmlDescription(flags);
                        }

                        document = _xmlDescription;
                    }
                }
                return document;
            }
        }

        public IEnumerable<VirXmlDomainDisk> DiskDevices
        {
            get
            {
                XmlNodeList devNodeList = XmlDescription.SelectNodes("//domain/devices/disk");

                XmlSerializer serializer = new XmlSerializer(typeof(VirXmlDomainDisk), defaultNamespace: "");
                foreach (XmlNode devNode in devNodeList)
                {
                    using (var reader = new XmlNodeReader(devNode))
                        yield return (VirXmlDomainDisk)serializer.Deserialize(reader);
                }
            }
        }

        public IEnumerable<VirXmlDomainGraphics> GraphicsDevices
        {
            get
            {
                XmlNodeList devNodeList = XmlDescription.SelectNodes("//domain/devices/graphics");
                XmlSerializer serializer = new XmlSerializer(typeof(VirXmlDomainGraphics), defaultNamespace: "");
                foreach (XmlNode devNode in devNodeList)
                {
                    using (var reader = new XmlNodeReader(devNode))
                        yield return (VirXmlDomainGraphics)serializer.Deserialize(reader);
                }
            }
        }

        public string GetGraphicsUri(VirXmlDomainGraphicsType preferredType = VirXmlDomainGraphicsType.VNC)
        {
            foreach (var type in new VirXmlDomainGraphicsType[] { preferredType, VirXmlDomainGraphicsType.VNC, VirXmlDomainGraphicsType.Spice, VirXmlDomainGraphicsType.RDP })
            {
                var graphics = this.GraphicsDevices.Where(t => t.Type == type).FirstOrDefault();
                if (graphics == null)
                    continue;

                return graphics.ToString(address: string.Equals(graphics.Listen, "0.0.0.0") ? _conn.Node.Hostname : null);
            }

            return null;
        }

        public IEnumerable<VirXmlDomainNetInterface> NetworkInterfaces
        {
            get
            {
                XmlNodeList devNodeList = XmlDescription.SelectNodes("//domain/devices/interface[@type='network' or @type='bridge']");
                XmlSerializer serializer = new XmlSerializer(typeof(VirXmlDomainNetInterface), defaultNamespace: "");
                foreach (XmlNode devNode in devNodeList)
                {
                    using (var reader = new XmlNodeReader(devNode))
                        yield return (VirXmlDomainNetInterface)serializer.Deserialize(reader);
                }
            }
        }

        public string MachineType
        {
            get { return XmlDescription.SelectSingleNode("//domain/os/type")?.Attributes["machine"]?.Value; }
        }

        public string MachineArch
        {
            get { return XmlDescription.SelectSingleNode("//domain/os/type")?.Attributes["arch"]?.Value; }
        }

        public string OsInfoId
        {
            get
            {
                var xmldoc = XmlDescription;
                XmlNamespaceManager ns = new XmlNamespaceManager(xmldoc.NameTable);
                ns.AddNamespace("libosinfo", VirXmlNamespace.LIBOSINFO);
                return xmldoc.SelectSingleNode("//domain/metadata/libosinfo:libosinfo/libosinfo:os", ns)?.Attributes["id"].Value;
            }
        }
        #endregion

        #region Events
        internal void DispatchDomainEvent(VirDomainEventArgs args)
        {
        }
        #endregion

        #region Object overrides
        public override int GetHashCode()
        {
            return UniqueId.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is LibvirtDomain && ((LibvirtDomain)obj).UniqueId.Equals(UniqueId);
        }

        public override string ToString()
        {
            return $"{typeof(LibvirtDomain).Name} name={Name}, uuid={UniqueId}, osType={OSType}";
        }
        #endregion

        #region Control

        /// <summary>
        /// Launch a defined domain. If the call succeeds the domain moves from the defined to the running domains pools. The domain will be paused only if restoring from managed state created from a paused domain.
        /// </summary>
        /// <returns>True on success</returns>
        public bool Create()
        {
            return NativeVirDomain.Create(_domainPtr) == 0;
        }

        /// <summary>
        /// Reset a domain immediately without any guest OS shutdown. Reset emulates the power reset button on a machine, where all hardware sees the RST line set and reinitializes internal state.
        /// </summary>
        /// <returns>True on success</returns>
        public bool Reset()
        {
            return NativeVirDomain.Reset(_domainPtr, 0) == 0;
        }

        /// <summary>
        /// Suspends an active domain, the process is frozen without further access to CPU resources and I/O but the memory used by the domain at the hypervisor level will stay allocated. 
        /// </summary>
        /// <returns>True on success</returns>
        public bool Suspend()
        {
            return NativeVirDomain.Suspend(_domainPtr) == 0;
        }

        /// <summary>
        /// Resume a suspended domain, the process is restarted from the state where it was frozen by calling virDomainSuspend(). This function may require privileged access Moreover, resume may not be supported if domain is in some special state like VIR_DOMAIN_PMSUSPENDED.
        /// </summary>
        /// <returns>True on success</returns>
        public bool Resume()
        {
            return NativeVirDomain.Resume(_domainPtr) == 0;
        }

        /// <summary>
        /// Shutdown a domain, the domain object is still usable thereafter, but the domain OS is being stopped. Note that the guest OS may ignore the request.
        /// </summary>
        /// <returns>True on success</returns>
        public bool Shutdown()
        {
            return NativeVirDomain.Shutdown(_domainPtr) == 0;
        }

        /// <summary>
        /// Shutdown a domain, the domain object is still usable thereafter, but the domain OS is being stopped. Note that the guest OS may ignore the request.
        /// </summary>
        /// <returns>True on success</returns>
        public bool ManagedSave()
        {
            return NativeVirDomain.ManagedSave(_domainPtr, VirDomainSaveRestoreFlags.Empty) == 0;
        }

        #endregion

        #region IDisposable implementation
        private Int32 _isDisposing = 0;

        /// <summary>
        /// Disposes the connection.
        /// </summary>
        public void Dispose()
        {
            if (Interlocked.CompareExchange(ref _isDisposing, 1, 0) == 1)
                return;

            Trace.WriteLine($"Disposing domain {this.ToString()}.");

            if (_domainPtr != IntPtr.Zero)
                NativeVirDomain.Free(_domainPtr);
        }
        #endregion
    }
}
