using System;
using System.Collections.Generic;

#nullable disable

namespace hotstar.Models
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            ContentCreatedByNavigations = new HashSet<Content>();
            ContentModifiedByNavigations = new HashSet<Content>();
            EpisodeCreatedByNavigations = new HashSet<Episode>();
            EpisodeModifiedByNavigations = new HashSet<Episode>();
            InverseModifiedByNavigation = new HashSet<User>();
            Payments = new HashSet<Payment>();
            PlaylistCreatedByNavigations = new HashSet<Playlist>();
            PlaylistModifiedByNavigations = new HashSet<Playlist>();
            PlaylistUsers = new HashSet<Playlist>();
            Resources = new HashSet<Resource>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public int? Age { get; set; }
        public int? Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsSubscribed { get; set; }
        public int? SubscriptionType { get; set; }
        public int? RoleId { get; set; }
        public int? ValidationOtp { get; set; }

        public virtual Object GenderNavigation { get; set; }
        public virtual User ModifiedByNavigation { get; set; }
        public virtual Role Role { get; set; }
        public virtual Object SubscriptionTypeNavigation { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Content> ContentCreatedByNavigations { get; set; }
        public virtual ICollection<Content> ContentModifiedByNavigations { get; set; }
        public virtual ICollection<Episode> EpisodeCreatedByNavigations { get; set; }
        public virtual ICollection<Episode> EpisodeModifiedByNavigations { get; set; }
        public virtual ICollection<User> InverseModifiedByNavigation { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Playlist> PlaylistCreatedByNavigations { get; set; }
        public virtual ICollection<Playlist> PlaylistModifiedByNavigations { get; set; }
        public virtual ICollection<Playlist> PlaylistUsers { get; set; }
        public virtual ICollection<Resource> Resources { get; set; }
    }
}
