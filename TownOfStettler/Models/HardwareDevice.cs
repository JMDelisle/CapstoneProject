using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class HardwareDevice
    {
        public HardwareDevice()
        {
            DeviceInformations = new HashSet<DeviceInformation>();
        }

        public int Id { get; set; }
        public string TypeOfHardware { get; set; } = null!;

        public virtual ICollection<DeviceInformation> DeviceInformations { get; set; }
    }
}
