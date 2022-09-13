using System;
using System.Collections.Generic;

#nullable disable

namespace FileHandling.Models
{
    public partial class ProductList
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public decimal? Pprice { get; set; }
    }
}
