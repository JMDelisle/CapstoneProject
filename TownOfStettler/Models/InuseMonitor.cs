using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class InuseMonitor
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int MonitorId { get; set; }

        public virtual DeviceInformation Device { get; set; } = null!;
        public virtual DisplayMonitor Monitor { get; set; } = null!;
    }
}
