using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class Part
    {
        public int Id { get; set; }
        public int OriginalDeviceId { get; set; }
        public int DeviceHistoryId { get; set; }
        public int? RamId { get; set; }
        public int? HardDriveId { get; set; }
        public int? MiscellaneousDriveId { get; set; }
        public int? VideoCardId { get; set; }
        public int? SoundCardId { get; set; }
        public string? Notes { get; set; }

        public virtual History DeviceHistory { get; set; } = null!;
        public virtual HardDrive? HardDrive { get; set; }
        public virtual DeviceInformation OriginalDevice { get; set; } = null!;
        public virtual Ram? Ram { get; set; }
        public virtual MiscellaneousDrive? MiscellaneousDrive { get; set; }
        public virtual SoundCard? SoundCard { get; set; }
        public virtual VideoCard? VideoCard { get; set; }
    }
}
