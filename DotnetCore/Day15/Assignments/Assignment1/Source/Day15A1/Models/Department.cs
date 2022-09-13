using System;
using System.Collections.Generic;

#nullable disable

namespace Day15A1.Models
{
    public partial class Department
    {
        public decimal DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public decimal? ManagerId { get; set; }
        public decimal? LocationId { get; set; }
    }
}
