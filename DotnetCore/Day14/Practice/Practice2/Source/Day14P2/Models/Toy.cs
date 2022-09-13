using System;
using System.Collections.Generic;

#nullable disable

namespace Day14P2.Models
{
    public partial class Toy
    {
        public Toy()
        {
            ItemsOrdereds = new HashSet<ItemsOrdered>();
            ToysPerPlants = new HashSet<ToysPerPlant>();
        }

        public int ToyId { get; set; }
        public string ToyName { get; set; }
        public int? Price { get; set; }

        public virtual ICollection<ItemsOrdered> ItemsOrdereds { get; set; }
        public virtual ICollection<ToysPerPlant> ToysPerPlants { get; set; }
    }
}
