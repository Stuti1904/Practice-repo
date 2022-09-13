using System;
using System.Collections.Generic;

#nullable disable

namespace Module17A1.Models
{
    public partial class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string Disease { get; set; }
        public int? DoctorId { get; set; }
        public int? Hcid { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual HealthCareAssistant Hc { get; set; }
    }
}
