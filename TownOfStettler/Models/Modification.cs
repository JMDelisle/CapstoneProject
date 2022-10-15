using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class Modification
    {
        public int Id { get; set; }
        public int? ProcessorId { get; set; }
        public int? RamId { get; set; }
        public int? HardDriveId { get; set; }
        public int? SecondaryDriveId { get; set; }
        public int? SoundCardId { get; set; }
        public int? VideoCardId { get; set; }
        public string? Notes { get; set; }

        public virtual HardDrive? HardDrive { get; set; }
        public virtual Processsor? Processor { get; set; }
        public virtual Ram? Ram { get; set; }
        public virtual SecondaryDrive? SecondaryDrive { get; set; }
        public virtual SoundCard? SoundCard { get; set; }
        public virtual VideoCard? VideoCard { get; set; }
    }
}
