﻿using System;
using System.Collections.Generic;


namespace TownOfStettler.Models
{
    public partial class DeviceInformation
    {
        public DeviceInformation()
        {
            EthernetNetworks = new HashSet<EthernetNetwork>();
            HardDrives = new HashSet<HardDrive>();
            Histories = new HashSet<History>();
            InstalledSoftwares = new HashSet<InstalledSoftware>();
            InuseMonitors = new HashSet<InuseMonitor>();
            Parts = new HashSet<Part>();
            Printers = new HashSet<Printer>();
            Processors = new HashSet<Processor>();
            Rams = new HashSet<Ram>();
            SecondaryDrives = new HashSet<SecondaryDrive>();
            SoundCards = new HashSet<SoundCard>();
            VideoCards = new HashSet<VideoCard>();
            Warranties = new HashSet<Warranty>();
        }

        public int Id { get; set; }
        public int DeviceTypeId { get; set; }
        public int OwnerLocation { get; set; }
        public string TosNumber { get; set; } = null!;
        public string SerialNumber { get; set; } = null!;
        public string ModelNumber { get; set; } = null!;
        public string? PowerSupply { get; set; }
        public string PurchaseStore { get; set; } = null!;
        public decimal PurchasePrice { get; set; }
        public DateOnly PurchaseDate { get; set; }
        public string OperatingSystem { get; set; } = null!;
        public bool Destroyed { get; set; }
        public string? Notes { get; set; }

        public virtual HardwareDevice DeviceType { get; set; } = null!;
        public virtual OwnerLocation OwnerLocationNavigation { get; set; } = null!;
        public virtual ICollection<EthernetNetwork> EthernetNetworks { get; set; }
        public virtual ICollection<HardDrive> HardDrives { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<InstalledSoftware> InstalledSoftwares { get; set; }
        public virtual ICollection<InuseMonitor> InuseMonitors { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
        public virtual ICollection<Printer> Printers { get; set; }
        public virtual ICollection<Processor> Processors { get; set; }
        public virtual ICollection<Ram> Rams { get; set; }
        public virtual ICollection<SecondaryDrive> SecondaryDrives { get; set; }
        public virtual ICollection<SoundCard> SoundCards { get; set; }
        public virtual ICollection<VideoCard> VideoCards { get; set; }
        public virtual ICollection<Warranty> Warranties { get; set; }
    }
}
