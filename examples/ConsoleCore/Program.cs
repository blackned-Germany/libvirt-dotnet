﻿using Libvirt;
using System;

namespace ConsoleCore
{
    class Program
    {
        private static void Connection_DomainEventReceived(object sender, VirDomainEventArgs e)
        {
            var domain = (LibvirtDomain)sender; // Note: this is null on undefined event
            Console.WriteLine($"EVENT: {e.UniqueId} {domain?.Name} {e.EventType.ToString()}");
        }

        static void Main(string[] args)
        {
            using (var connection = LibvirtConnection.Open())
            {
                //connection.DomainEventReceived += Connection_DomainEventReceived;

                foreach (var domain in connection.Domains)
                {
                    Console.WriteLine($"{domain.UniqueId} {domain.Name} {domain.State}");
                    foreach (var nic in domain.NetworkInterfaces)
                        Console.WriteLine($"   NIC {nic.Address.ToString()} bridge={nic.Source.Network}, mac={nic.MAC.Address}");

                    break;
                }

                //Console.WriteLine();
                //Console.WriteLine("[ENTER] to exit");
                //Console.ReadLine();
            }
        }
    }
}
