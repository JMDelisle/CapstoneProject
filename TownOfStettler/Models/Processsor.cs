using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class Processsor
    {
        public Processsor()
        {
            Modifications = new HashSet<Modification>();
        }

        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Type { get; set; } = null!;
        public decimal SpeedGhz { get; set; }
        public string SerialNumber { get; set; } = null!;
        public int Generation { get; set; }
        public int CoreCount { get; set; }
        public bool Destroyed { get; set; }
        public string? Notes { get; set; }

        public virtual DeviceInformation Device { get; set; } = null!;
        public virtual ICollection<Modification> Modifications { get; set; }
    }
}
