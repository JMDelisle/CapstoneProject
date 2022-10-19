using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class Printer
    {
        public int Id { get; set; }
        public int OwnerLocation { get; set; }
        public int? DeviceId { get; set; }
        public string Type { get; set; } = null!;
        public string ConnectionType { get; set; } = null!;
        public int? History { get; set; }
        public string? Notes { get; set; }

        public virtual DeviceInformation? Device { get; set; }
        public virtual History? HistoryNavigation { get; set; }
        public virtual OwnerLocation OwnerLocationNavigation { get; set; } = null!;
    }
}
