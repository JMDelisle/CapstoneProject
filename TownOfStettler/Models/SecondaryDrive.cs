﻿using System;
using System.Collections.Generic;

namespace TownOfStettler.Models
{
    public partial class SecondaryDrive
    {
        public SecondaryDrive()
        {
            Modifications = new HashSet<Modification>();
            Parts = new HashSet<Part>();
        }

        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Type { get; set; } = null!;
        public bool Removable { get; set; }
        public string SerialNumber { get; set; } = null!;
        public bool Destroyed { get; set; }
        public string? Notes { get; set; }

        public virtual DeviceInformation Device { get; set; } = null!;
        public virtual ICollection<Modification> Modifications { get; set; }
        public virtual ICollection<Part> Parts { get; set; }
    }
}
