using System;
using System.Collections.Generic;

#nullable disable

namespace Module17A1.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Patients = new HashSet<Patient>();
        }

        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Speciality { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
