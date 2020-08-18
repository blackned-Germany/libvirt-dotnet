﻿/*
 * Copyright (C)
 *
 *   Arnaud Champion <arnaud.champion@devatom.fr>
 *   Jaromír Červenka <cervajz@cervajz.com>
 *   Marcus Zoller <marcus.zoller@idnt.net>
 *
 * and the Libvirt-CSharp contributors.
 * 
 * Licensed under the GNU Lesser General Public Library, Version 2.1 (the "License");
 * you may not use this file except in compliance with the License. You may obtain a 
 * copy of the License at
 *
 * https://www.gnu.org/licenses/lgpl-2.1.en.html
 * 
 * or see COPYING.LIB for a copy of the license terms. Unless required by applicable 
 * law or agreed to in writing, software distributed under the License is distributed 
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express 
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libvirt
{
    ///<summary>
    /// Memory statistics tags
    ///</summary>
    [Flags]
    public enum VirDomainMemoryStatTags
    {
        /// <summary>
        ///  The total amount of memory written out to swap space (in kB).
        /// </summary>
        VIR_DOMAIN_MEMORY_STAT_SWAP_IN = 0,
        /// <summary>
        /// * Page faults occur when a process makes a valid access to virtual memory * that is not available. When servicing the page fault, if disk IO is * required, it is considered a major fault. If not, it is a minor fault. * These are expressed as the number of faults that have occurred. *
        /// </summary>
        VIR_DOMAIN_MEMORY_STAT_SWAP_OUT = 1,
#pragma warning disable 1591
        VIR_DOMAIN_MEMORY_STAT_MAJOR_FAULT = 2,
#pragma warning restore 1591
        /// <summary>
        /// * The amount of memory left completely unused by the system. Memory that * is available but used for reclaimable caches should NOT be reported as * free. This value is expressed in kB. *
        /// </summary>
        VIR_DOMAIN_MEMORY_STAT_MINOR_FAULT = 3,
        /// <summary>
        /// * The total amount of usable memory as seen by the domain. This value * may be less than the amount of memory assigned to the domain if a * balloon driver is in use or if the guest OS does not initialize all * assigned pages. This value is expressed in kB. *
        /// </summary>
        VIR_DOMAIN_MEMORY_STAT_UNUSED = 4,
        /// <summary>
        /// * The number of statistics supported by this version of the interface. * To add new statistics, add them to the enum and increase this value. *
        /// </summary>
        VIR_DOMAIN_MEMORY_STAT_AVAILABLE = 5,
        /// <summary>
        /// * Current balloon value (in KB).
        /// </summary>
        VIR_DOMAIN_MEMORY_STAT_ACTUAL_BALLOON = 6,
        /// <summary>
        /// * Resident Set Size of the process running the domain. This value is in kB
        /// </summary>
        VIR_DOMAIN_MEMORY_STAT_RSS = 7,
        /// <summary>
        /// * How much the balloon can be inflated without pushing the guest system to swap, corresponds to 'Available' in /proc/meminfo
        /// </summary>
        VIR_DOMAIN_MEMORY_STAT_USABLE = 8,
        /// <summary>
        /// * Timestamp of the last update of statistics, in seconds.
        /// </summary>
        VIR_DOMAIN_MEMORY_STAT_LAST_UPDATE = 9,
        /// <summary>
        /// * The amount of memory, that can be quickly reclaimed without additional I/O (in kB). Typically these pages are used for caching files from disk.
        /// </summary>
        VIR_DOMAIN_MEMORY_STAT_DISK_CACHES = 10,
        /// <summary>
        /// * The number of successful huge page allocations from inside the domain via virtio balloon.
        /// </summary>
        VIR_DOMAIN_MEMORY_STAT_HUGETLB_PGALLOC = 11,
        /// <summary>
        /// * The number of failed huge page allocations from inside the domain via virtio balloon.
        /// </summary>
        VIR_DOMAIN_MEMORY_STAT_HUGETLB_PGFAIL = 12,
        /// <summary>
        /// * The number of statistics supported by this version of the interface. To add new statistics, add them to the enum and increase this value.
        /// </summary>
#pragma warning disable 1591
        VIR_DOMAIN_MEMORY_STAT_NR = 13,
#pragma warning restore 1591
    }
}
