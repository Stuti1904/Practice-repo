using System;
using System.Collections.Generic;

#nullable disable

namespace hotstar.Models
{
    public partial class Resource
    {
        public Resource()
        {
            Contents = new HashSet<Content>();
            Episodes = new HashSet<Episode>();
        }

        public int ResourceId { get; set; }
        public string Url { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
    }
}
