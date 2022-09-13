using System;
using System.Collections.Generic;

#nullable disable

namespace Module17A1.Models
{
    public partial class HealthCareAssistant
    {
        public HealthCareAssistant()
        {
            Patients = new HashSet<Patient>();
        }

        public int Hcid { get; set; }
        public string Hcname { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
