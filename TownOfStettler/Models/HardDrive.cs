using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class HardDrive
    {
        public HardDrive()
        {
            Modifications = new HashSet<Modification>();
            Parts = new HashSet<Part>();
        }

        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Type { get; set; } = null!;
        public string SizeGb { get; set; } = null!;
        public string SerialNumber { get; set; } = null!;
        public bool Destroyed { get; set; }
        public string Notes { get; set; } = null!;

        public virtual DeviceInformation Device { get; set; } = null!;
        public virtual ICollection<Modification> Modifications { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
    }
}
