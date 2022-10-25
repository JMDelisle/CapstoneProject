using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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

        [NotMapped]
        public string SubEndDate
        {
            get
            {
                if (SubscriptionEndDate == null)
                {
                    return "";
                }
                else
                {
                    return (SubscriptionEndDate?.ToString("yyyy-MM-dd"));
                }

            }
        }

        [NotMapped]
        public string PurchDate
        {
            get
            {
                if (PurchaseDate == null)
                {
                    return "";
                }
                else
                {
                    return (PurchaseDate?.ToString("yyyy-MM-dd"));
                }

            }
        }

        [NotMapped]
        public string EndOfSupport
        {
            get
            {
                if (EndOfSupportDate == null)
                {
                    return "";
                }
                else
                {
                    return (EndOfSupportDate?.ToString("yyyy-MM-dd"));
                }

            }
        }

    }
}
