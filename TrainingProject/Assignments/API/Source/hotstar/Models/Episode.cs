using System;
using System.Collections.Generic;

#nullable disable

namespace hotstar.Models
{
    public partial class Episode
    {
        public Episode()
        {
            Playlists = new HashSet<Playlist>();
        }

        public int EpisodeId { get; set; }
        public int? ContentId { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string Description { get; set; }
        public int? ResourceId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Content Content { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual User ModifiedByNavigation { get; set; }
        public virtual Resource Resource { get; set; }
        public virtual ICollection<Playlist> Playlists { get; set; }
    }
}
