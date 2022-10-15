using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class DisplayMonitor
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int ViewSizeInches { get; set; }
        public string ViewType { get; set; } = null!;
        public string Resolution { get; set; } = null!;
        public int? RefreshRateHz { get; set; }
        public string SerialNumber { get; set; } = null!;
        public string OutputType { get; set; } = null!;
        public int NumberOfOutputs { get; set; }
        public string? Notes { get; set; }

        public virtual DeviceInformation Device { get; set; } = null!;
    }
}
