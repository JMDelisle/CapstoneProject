using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class DeviceInformation
    {
        public DeviceInformation()
        {
            DisplayMonitors = new HashSet<DisplayMonitor>();
            EthernetNetworks = new HashSet<EthernetNetwork>();
            HardDrives = new HashSet<HardDrive>();
            Histories = new HashSet<History>();
            OwnerLocations = new HashSet<OwnerLocation>();
            Parts = new HashSet<Part>();
            Printers = new HashSet<Printer>();
            Processsors = new HashSet<Processsor>();
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
        public double Destroyed { get; set; }
        public string? Notes { get; set; }
        public int? InstalledSoftware01 { get; set; }
        public int? InstalledSoftware02 { get; set; }
        public int? InstalledSoftware03 { get; set; }
        public int? InstalledSoftware04 { get; set; }
        public int? InstalledSoftware05 { get; set; }
        public int? InstalledSoftware06 { get; set; }
        public int? InstalledSoftware07 { get; set; }
        public int? InstalledSoftware08 { get; set; }
        public int? InstalledSoftware09 { get; set; }
        public int? InstalledSoftware10 { get; set; }
        public int? InstalledSoftware11 { get; set; }
        public int? InstalledSoftware12 { get; set; }
        public int? InstalledSoftware13 { get; set; }
        public int? InstalledSoftware14 { get; set; }
        public int? InstalledSoftware15 { get; set; }
        public int? InstalledSoftware16 { get; set; }
        public int? InstalledSoftware17 { get; set; }
        public int? InstalledSoftware18 { get; set; }
        public int? InstalledSoftware19 { get; set; }
        public int? InstalledSoftware20 { get; set; }

        public virtual HardwareDevice DeviceType { get; set; } = null!;
        public virtual Software? InstalledSoftware01Navigation { get; set; }
        public virtual Software? InstalledSoftware02Navigation { get; set; }
        public virtual Software? InstalledSoftware03Navigation { get; set; }
        public virtual Software? InstalledSoftware04Navigation { get; set; }
        public virtual Software? InstalledSoftware05Navigation { get; set; }
        public virtual Software? InstalledSoftware06Navigation { get; set; }
        public virtual Software? InstalledSoftware07Navigation { get; set; }
        public virtual Software? InstalledSoftware08Navigation { get; set; }
        public virtual Software? InstalledSoftware09Navigation { get; set; }
        public virtual Software? InstalledSoftware10Navigation { get; set; }
        public virtual Software? InstalledSoftware11Navigation { get; set; }
        public virtual Software? InstalledSoftware12Navigation { get; set; }
        public virtual Software? InstalledSoftware13Navigation { get; set; }
        public virtual Software? InstalledSoftware14Navigation { get; set; }
        public virtual Software? InstalledSoftware15Navigation { get; set; }
        public virtual Software? InstalledSoftware16Navigation { get; set; }
        public virtual Software? InstalledSoftware17Navigation { get; set; }
        public virtual Software? InstalledSoftware18Navigation { get; set; }
        public virtual Software? InstalledSoftware19Navigation { get; set; }
        public virtual Software? InstalledSoftware20Navigation { get; set; }
        public virtual OwnerLocation OwnerLocationNavigation { get; set; } = null!;
        public virtual ICollection<DisplayMonitor> DisplayMonitors { get; set; }
        public virtual ICollection<EthernetNetwork> EthernetNetworks { get; set; }
        public virtual ICollection<HardDrive> HardDrives { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<OwnerLocation> OwnerLocations { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
        public virtual ICollection<Printer> Printers { get; set; }
        public virtual ICollection<Processsor> Processsors { get; set; }
        public virtual ICollection<Ram> Rams { get; set; }
        public virtual ICollection<SecondaryDrive> SecondaryDrives { get; set; }
        public virtual ICollection<SoundCard> SoundCards { get; set; }
        public virtual ICollection<VideoCard> VideoCards { get; set; }
        public virtual ICollection<Warranty> Warranties { get; set; }
    }
}
