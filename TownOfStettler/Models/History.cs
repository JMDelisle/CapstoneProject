using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class History
    {
        public History()
        {
            Parts = new HashSet<Part>();
        }

        public int Id { get; set; }
        public int DeviceId { get; set; }
        public int PartsChanged { get; set; }
        public int PastOwnerS { get; set; }
        public bool Wiped { get; set; }
        public bool PartsRemoved { get; set; }
        public DateOnly DateOfChanges { get; set; }
        public DateOnly? OutOfServiceDate { get; set; }
        public string? Notes { get; set; }

        public virtual DeviceInformation Device { get; set; } = null!;
        public virtual OwnerLocation PastOwnerSNavigation { get; set; } = null!;
        public virtual ICollection<Part> Parts { get; set; }
    }
}
