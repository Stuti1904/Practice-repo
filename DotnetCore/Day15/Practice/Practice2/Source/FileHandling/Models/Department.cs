using System;
using System.Collections.Generic;

#nullable disable

namespace FileHandling.Models
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
