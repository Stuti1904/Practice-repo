using System;
using System.Collections.Generic;

#nullable disable

namespace hotstar.Models
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int? UserId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? ValidTill { get; set; }
        public string UpiphoneNumber { get; set; }
        public int? PaymentStatus { get; set; }

        public virtual Object PaymentStatusNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
