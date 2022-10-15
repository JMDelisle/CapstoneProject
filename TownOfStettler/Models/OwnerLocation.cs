using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class OwnerLocation
    {
        public OwnerLocation()
        {
            DeviceInformations = new HashSet<DeviceInformation>();
            Histories = new HashSet<History>();
            OtherHardwares = new HashSet<OtherHardware>();
        }

        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Notes { get; set; }

        public virtual DeviceInformation Device { get; set; } = null!;
        public virtual ICollection<DeviceInformation> DeviceInformations { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<OtherHardware> OtherHardwares { get; set; }
    }
}
