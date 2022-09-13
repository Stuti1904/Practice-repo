using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Assignment.Models
{
    public partial class Department
    {
        public Department()
        {
            Doctors = new HashSet<Doctor>();
            HealthCareAssistants = new HashSet<HealthCareAssistant>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Doctor> Doctors { get; set; }
        public virtual ICollection<HealthCareAssistant> HealthCareAssistants { get; set; }
    }
}
