using System;
using System.Collections.Generic;

#nullable disable

namespace hotstar.Models
{
    public partial class Object
    {
        public Object()
        {
            Contents = new HashSet<Content>();
            Payments = new HashSet<Payment>();
            UserGenderNavigations = new HashSet<User>();
            UserSubscriptionTypeNavigations = new HashSet<User>();
        }

        public int ObjectId { get; set; }
        public string ObjectName { get; set; }
        public int? ObjectTypeId { get; set; }

        public virtual ObjectType ObjectType { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<User> UserGenderNavigations { get; set; }
        public virtual ICollection<User> UserSubscriptionTypeNavigations { get; set; }
    }
}
