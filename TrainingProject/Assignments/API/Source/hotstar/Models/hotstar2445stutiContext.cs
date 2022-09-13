using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace hotstar.Models
{
    public partial class hotstar2445stutiContext : DbContext
    {
        public hotstar2445stutiContext()
        {
        }

        public hotstar2445stutiContext(DbContextOptions<hotstar2445stutiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminUser> AdminUsers { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<Episode> Episodes { get; set; }
        public virtual DbSet<GeneralInfo> GeneralInfos { get; set; }
        public virtual DbSet<Object> Objects { get; set; }
        public virtual DbSet<ObjectType> ObjectTypes { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Playlist> Playlists { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=43.204.134.14;Database=hotstar-2445-stuti;User Id=hotstar-2445-stuti;Password=CaXHmZ0B98cotE7;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AdminUser");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Comment1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Comment");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.ContentId)
                    .HasConstraintName("FK__Comments__Conten__3E1D39E1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Comments__UserId__3D2915A8");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("Content");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.Cast)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("CreatedBY");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Dislikes).HasColumnName("dislikes");

                entity.Property(e => e.HorizontalImage)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.IsPaid).HasColumnName("isPaid");

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Likes).HasColumnName("likes");

                entity.Property(e => e.ModifiedBy).HasColumnName("ModifiedBY");

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.ReleasedDate).HasColumnType("date");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.Title)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.VerticalImage)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Views).HasColumnName("views");

                entity.HasOne(d => d.ContentTypeNavigation)
                    .WithMany(p => p.Contents)
                    .HasForeignKey(d => d.ContentType)
                    .HasConstraintName("FK__Content__Content__74AE54BC");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ContentCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__Content__Created__778AC167");

                entity.HasOne(d => d.GenreNavigation)
                    .WithMany(p => p.Contents)
                    .HasForeignKey(d => d.Genre)
                    .HasConstraintName("FK__Content__Genre__75A278F5");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ContentModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__Content__Modifie__787EE5A0");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.Contents)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK__Content__Resourc__76969D2E");
            });

            modelBuilder.Entity<Episode>(entity =>
            {
                entity.ToTable("Episode");

                entity.Property(e => e.EpisodeId).HasColumnName("EpisodeID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("ModifiedBY");

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.ReleasedDate).HasColumnType("date");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.Title)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Episodes)
                    .HasForeignKey(d => d.ContentId)
                    .HasConstraintName("FK__Episode__Content__7C4F7684");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EpisodeCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__Episode__Created__7E37BEF6");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EpisodeModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__Episode__Modifie__7F2BE32F");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.Episodes)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK__Episode__Resourc__7D439ABD");
            });

            modelBuilder.Entity<GeneralInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GeneralInfo");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.ContentType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("contentType");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IsPaid).HasColumnName("isPaid");

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Views).HasColumnName("views");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Object>(entity =>
            {
                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectTypeId).HasColumnName("ObjectTypeID");

                entity.HasOne(d => d.ObjectType)
                    .WithMany(p => p.Objects)
                    .HasForeignKey(d => d.ObjectTypeId)
                    .HasConstraintName("FK__Objects__ObjectT__5DCAEF64");
            });

            modelBuilder.Entity<ObjectType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__ObjectTy__516F0395EF61871C");

                entity.ToTable("ObjectType");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.UpiphoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UPIPhoneNumber");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ValidTill).HasColumnType("date");

                entity.HasOne(d => d.PaymentStatusNavigation)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentStatus)
                    .HasConstraintName("FK__Payment__Payment__6EF57B66");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Payment__UserID__6E01572D");
            });

            modelBuilder.Entity<Playlist>(entity =>
            {
                entity.ToTable("Playlist");

                entity.Property(e => e.PlaylistId).HasColumnName("PlaylistID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.EpisodeId).HasColumnName("EpisodeID");

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Playlists)
                    .HasForeignKey(d => d.ContentId)
                    .HasConstraintName("FK__Playlist__Conten__02FC7413");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PlaylistCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__Playlist__Create__04E4BC85");

                entity.HasOne(d => d.Episode)
                    .WithMany(p => p.Playlists)
                    .HasForeignKey(d => d.EpisodeId)
                    .HasConstraintName("FK__Playlist__Episod__03F0984C");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PlaylistModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__Playlist__Modifi__05D8E0BE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PlaylistUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Playlist__UserID__02084FDA");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Url)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Resources)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK__Resources__Creat__71D1E811");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("date");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.GenderNavigation)
                    .WithMany(p => p.UserGenderNavigations)
                    .HasForeignKey(d => d.Gender)
                    .HasConstraintName("FK__Users__Gender__68487DD7");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InverseModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK__Users__ModifiedB__693CA210");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Users__RoleID__6B24EA82");

                entity.HasOne(d => d.SubscriptionTypeNavigation)
                    .WithMany(p => p.UserSubscriptionTypeNavigations)
                    .HasForeignKey(d => d.SubscriptionType)
                    .HasConstraintName("FK__Users__Subscript__6A30C649");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
