﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TownOfStettler.Models
{
    public partial class History
    {
        public History()
        {
            DisplayMonitors = new HashSet<DisplayMonitor>();
            OtherHardwares = new HashSet<OtherHardware>();
            Parts = new HashSet<Part>();
            Printers = new HashSet<Printer>();
        }

        public int Id { get; set; }
        public int DeviceTypeId { get; set; }
        public int? DeviceId { get; set; }
        public int? PartsChanged { get; set; }
        public int? PastOwnerS { get; set; }
        public bool? Wiped { get; set; }
        public int? PartsRemoved { get; set; }
        public DateOnly DateOfChanges { get; set; }
        public DateOnly? OutOfServiceDate { get; set; }
        public string? Notes { get; set; }

        public virtual DeviceInformation? Device { get; set; }
        public virtual HardwareDevice DeviceType { get; set; } = null!;
        public virtual Modification? PartsChangedNavigation { get; set; }
        public virtual OwnerLocation? PastOwnerSNavigation { get; set; }
        public virtual ICollection<DisplayMonitor> DisplayMonitors { get; set; }
        public virtual ICollection<OtherHardware> OtherHardwares { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
        public virtual ICollection<Printer> Printers { get; set; }

        [NotMapped]
        public string StrDoC
        {
            get
            {
                return (DateOfChanges.ToString("yyyy-MM-dd"));

            }
        }

        [NotMapped]
        public string StrOos
        {
            get
            {
                if(OutOfServiceDate == null)
                {
                    return "";
                }
                else
                {
                    return (OutOfServiceDate?.ToString("yyyy-MM-dd"));
                }

            }
        }


    }
}
