﻿using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class Modification
    {
        public Modification()
        {
            Histories = new HashSet<History>();
        }

        public int Id { get; set; }
        public int? ProcessorId { get; set; }
        public int? RamId { get; set; }
        public int? HardDriveId { get; set; }
        public int? MiscellaneousDriveId { get; set; }
        public int? SoundCardId { get; set; }
        public int? VideoCardId { get; set; }
        public string? Notes { get; set; }

        public virtual HardDrive? HardDrive { get; set; }
        public virtual Processor? Processor { get; set; }
        public virtual Ram? Ram { get; set; }
        public virtual MiscellaneousDrive? MiscellaneousDrive { get; set; }
        public virtual SoundCard? SoundCard { get; set; }
        public virtual VideoCard? VideoCard { get; set; }
        public virtual ICollection<History> Histories { get; set; }
    }
}
