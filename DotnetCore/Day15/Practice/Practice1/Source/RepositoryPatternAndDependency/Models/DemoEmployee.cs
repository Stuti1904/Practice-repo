using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryPatternAndDependency.Models
{
    public partial class DemoEmployee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal? EmpSalary { get; set; }
        public DateTime? JoiningDate { get; set; }
        public int? DepartmentId { get; set; }
        public int? ManagerId { get; set; }

        public virtual Department Department { get; set; }
    }
}
