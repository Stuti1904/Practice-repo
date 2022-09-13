using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryPatternAndDependency.Models
{
    public partial class Department
    {
        public Department()
        {
            DemoEmployees = new HashSet<DemoEmployee>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<DemoEmployee> DemoEmployees { get; set; }
    }
}
