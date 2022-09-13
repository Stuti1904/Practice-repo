using System;
using System.Collections.Generic;

#nullable disable

namespace Day14P2.Models
{
    public partial class Order
    {
        public Order()
        {
            ItemsOrdereds = new HashSet<ItemsOrdered>();
        }

        public int OrderId { get; set; }
        public DateTime? OrderedDate { get; set; }
        public int? CustomerId { get; set; }
        public bool? Cod { get; set; }
        public int? ToShipId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ToShipAddress ToShip { get; set; }
        public virtual ICollection<ItemsOrdered> ItemsOrdereds { get; set; }
    }
}
