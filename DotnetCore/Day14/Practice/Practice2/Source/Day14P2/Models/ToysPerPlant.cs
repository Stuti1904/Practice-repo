﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Day14P2.Models
{
    public partial class ToysPerPlant
    {
        public int TpId { get; set; }
        public int? PlantId { get; set; }
        public int? ToyId { get; set; }
        public int? Quantity { get; set; }

        public virtual ManufacturePlant Plant { get; set; }
        public virtual Toy Toy { get; set; }
    }
}
