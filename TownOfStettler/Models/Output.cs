using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TownOfStettler.Models
{
    public partial class Output
    {
        public string Type { get; set; } = null!;
        public int VideoCardId { get; set; }
        public int NumberOfOutputs { get; set; }
        public string? Notes { get; set; }

        public virtual VideoCard VideoCard { get; set; } = null!;

        [NotMapped]
        public string TypeId => Type + "-" + VideoCardId;

    }
}
