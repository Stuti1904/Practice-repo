using System;
using System.Collections.Generic;

#nullable disable

namespace hotstar.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int? UserId { get; set; }
        public int? ContentId { get; set; }
        public string Comment1 { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Content Content { get; set; }
        public virtual User User { get; set; }
    }
}
