using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class OtherHardware
    {
        public int Id { get; set; }
        public int OwnerLocation { get; set; }
        public string TosNumber { get; set; } = null!;
        public string TypeOfDevice { get; set; } = null!;
        public bool Destroyed { get; set; }
        public int? History { get; set; }
        public string? Notes { get; set; }

        public virtual History? HistoryNavigation { get; set; }
        public virtual OwnerLocation OwnerLocationNavigation { get; set; } = null!;
    }
}
