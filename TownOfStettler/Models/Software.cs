using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class Software
    {
        public Software()
        {
            DeviceInformationInstalledSoftware01Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware02Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware03Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware04Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware05Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware06Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware07Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware08Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware09Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware10Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware11Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware12Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware13Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware14Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware15Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware16Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware17Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware18Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware19Navigations = new HashSet<DeviceInformation>();
            DeviceInformationInstalledSoftware20Navigations = new HashSet<DeviceInformation>();
        }

        public int Id { get; set; }
        public string? ProductKey { get; set; }
        public string SoftwareName { get; set; } = null!;
        public string? AssociatedAccount { get; set; }
        public bool Subscription { get; set; }
        public DateOnly? SubscriptionEndDate { get; set; }
        public DateOnly? PurchaseDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int DevicesAllowed { get; set; }
        public DateOnly? EndOfSupportDate { get; set; }

        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware01Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware02Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware03Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware04Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware05Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware06Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware07Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware08Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware09Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware10Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware11Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware12Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware13Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware14Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware15Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware16Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware17Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware18Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware19Navigations { get; set; }
        public virtual ICollection<DeviceInformation> DeviceInformationInstalledSoftware20Navigations { get; set; }
    }
}
