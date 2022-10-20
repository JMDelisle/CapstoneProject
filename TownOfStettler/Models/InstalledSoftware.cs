using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class InstalledSoftware
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int SoftwareId { get; set; }

        public virtual DeviceInformation Device { get; set; } = null!;
        public virtual Software Software { get; set; } = null!;
    }
}
