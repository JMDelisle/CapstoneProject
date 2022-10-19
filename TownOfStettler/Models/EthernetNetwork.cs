using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class EthernetNetwork
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Speed { get; set; } = null!;
        public bool Wireless { get; set; }
        public bool Bluetooth { get; set; }
        public string SerialNumber { get; set; } = null!;
        public bool Destroyed { get; set; }
        public string? Notes { get; set; }

        public virtual DeviceInformation Device { get; set; } = null!;
    }
}
