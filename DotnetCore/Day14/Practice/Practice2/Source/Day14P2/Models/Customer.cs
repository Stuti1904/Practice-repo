using System;
using System.Collections.Generic;

#nullable disable

namespace Day14P2.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
            ToShipAddresses = new HashSet<ToShipAddress>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ToShipAddress> ToShipAddresses { get; set; }
    }
}
