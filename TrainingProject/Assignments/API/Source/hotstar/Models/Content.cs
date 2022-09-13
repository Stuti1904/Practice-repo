using System;
using System.Collections.Generic;

#nullable disable

namespace hotstar.Models
{
    public partial class Content
    {
        public Content()
        {
            Comments = new HashSet<Comment>();
            Episodes = new HashSet<Episode>();
            Playlists = new HashSet<Playlist>();
        }

        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string Description { get; set; }
        public int? ContentType { get; set; }
        public int? Genre { get; set; }
        public int? ResourceId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string Cast { get; set; }
        public int? LengthInMinutes { get; set; }
        public bool? IsPaid { get; set; }
        public int? Likes { get; set; }
        public int? Dislikes { get; set; }
        public int? Views { get; set; }
        public string HorizontalImage { get; set; }
        public string VerticalImage { get; set; }

        public virtual ObjectType ContentTypeNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Object GenreNavigation { get; set; }
        public virtual User ModifiedByNavigation { get; set; }
        public virtual Resource Resource { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
        public virtual ICollection<Playlist> Playlists { get; set; }
    }
}
