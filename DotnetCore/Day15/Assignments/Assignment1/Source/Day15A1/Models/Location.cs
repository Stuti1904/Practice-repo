﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Day15A1.Models
{
    public partial class Location
    {
        public decimal LocationId { get; set; }
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string CountryId { get; set; }
    }
}
