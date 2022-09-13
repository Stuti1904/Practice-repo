using System;
using System.Collections.Generic;

#nullable disable

namespace Day14P2.Models
{
    public partial class ManufacturePlant
    {
        public ManufacturePlant()
        {
            ToysPerPlants = new HashSet<ToysPerPlant>();
        }

        public int PlantId { get; set; }
        public string PlantName { get; set; }
        public string Location { get; set; }
        public int? Pincode { get; set; }

        public virtual ICollection<ToysPerPlant> ToysPerPlants { get; set; }
    }
}
