using System;
using System.Collections.Generic;

#nullable disable

namespace hotstar.Models
{
    public partial class Playlist
    {
        public int PlaylistId { get; set; }
        public int? UserId { get; set; }
        public int? ContentId { get; set; }
        public int? EpisodeId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Content Content { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Episode Episode { get; set; }
        public virtual User ModifiedByNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
