using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class Software
    {
        public Software()
        {
            InstalledSoftwares = new HashSet<InstalledSoftware>();
        }

        public int Id { get; set; }
        public string? ProductKey { get; set; }
        public string SoftwareName { get; set; } = null!;
        public string? AssociatedAccount { get; set; }
        public bool? Subscription { get; set; }
        public DateOnly? SubscriptionEndDate { get; set; }
        public DateOnly? PurchaseDate { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int? DevicesAllowed { get; set; }
        public DateOnly? EndOfSupportDate { get; set; }
        public string? Notes { get; set; }

        public virtual ICollection<InstalledSoftware> InstalledSoftwares { get; set; }
    }
}
