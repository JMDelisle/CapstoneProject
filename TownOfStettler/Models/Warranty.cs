﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TownOfStettler.Models
{
    public partial class Warranty
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string TypeOfWarranty { get; set; } = null!;
        public string LengthOfWarranty { get; set; } = null!;
        public DateOnly? WarrantyExpiryDate { get; set; }
        public string? Notes { get; set; }

        public virtual DeviceInformation Device { get; set; } = null!;

        //[NotMapped]
        //public string StrIntDate
        //{
        //    get
        //    {
        //        // return (InterestAppliedDate.ToString("yyyy, dd MMMM"));
        //        return (WarrantyExpiryDate.ToString("yyyy-MM-dd"));

        //    }
        //}

    }
}
