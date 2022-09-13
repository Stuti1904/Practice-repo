using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryPatternAndDependency.Models
{
    public partial class UpdatedList
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public decimal? PPrice { get; set; }
    }
}
