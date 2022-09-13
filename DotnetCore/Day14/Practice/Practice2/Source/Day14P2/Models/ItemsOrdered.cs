using System;
using System.Collections.Generic;

#nullable disable

namespace Day14P2.Models
{
    public partial class ItemsOrdered
    {
        public int ItemsId { get; set; }
        public int? OrderId { get; set; }
        public int? ToyId { get; set; }
        public int? Quantity { get; set; }
        public int? TotalAmount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Toy Toy { get; set; }
    }
}
