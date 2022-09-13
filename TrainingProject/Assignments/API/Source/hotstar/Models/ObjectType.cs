using System;
using System.Collections.Generic;

#nullable disable

namespace hotstar.Models
{
    public partial class ObjectType
    {
        public ObjectType()
        {
            Contents = new HashSet<Content>();
            Objects = new HashSet<Object>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<Content> Contents { get; set; }
        public virtual ICollection<Object> Objects { get; set; }
    }
}
