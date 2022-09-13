using System;
using System.Collections.Generic;

#nullable disable

namespace Day14P2.Models
{
    public partial class ToShipAddress
    {
        public ToShipAddress()
        {
            Orders = new HashSet<Order>();
        }

        public int ToShipId { get; set; }
        public int? CustomerId { get; set; }
        public string Address { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
