﻿/*
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
using System.Text;
using System.Xml.Serialization;

namespace Libvirt
{
    [Serializable]
    [XmlRoot(ElementName = "graphics", Namespace = "")]
    public class VirXmlDomainGraphics
    {
        [XmlAttribute(AttributeName = "type")]
        public VirXmlDomainGraphicsType Type { get; set; }

        [XmlAttribute(AttributeName = "listen")]
        public string Listen { get; set; }

        [XmlAttribute(AttributeName = "port")]
        public int Port { get; set; }

        [XmlAttribute(AttributeName = "autoport")]
        private string _autoport { get; set; }

        [XmlIgnore]
        public bool IsAutoPort {  get { return string.Equals("yes", _autoport); } }

        public string ToString(string address = null)
        {
            return $"{Type.ToString().ToLower()}://{address ?? Listen}:{Port}";
        }

        public override string ToString()
        {
            return ToString(address:null);
        }
    }
}
