using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Day14P2.Models
{
    public partial class ToyCompanyContext : DbContext
    {
        public ToyCompanyContext()
        {
        }

        public ToyCompanyContext(DbContextOptions<ToyCompanyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ItemsOrdered> ItemsOrdereds { get; set; }
        public virtual DbSet<ManufacturePlant> ManufacturePlants { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ToShipAddress> ToShipAddresses { get; set; }
        public virtual DbSet<Toy> Toys { get; set; }
        public virtual DbSet<ToysPerPlant> ToysPerPlants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PC0753\\MSSQL2019;Database=ToyCompany;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemsOrdered>(entity =>
            {
                entity.HasKey(e => e.ItemsId)
                    .HasName("PK__ItemsOrd__19AFBB7EDC0417B3");

                entity.ToTable("ItemsOrdered");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ToyId).HasColumnName("ToyID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ItemsOrdereds)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__ItemsOrde__Order__49C3F6B7");

                entity.HasOne(d => d.Toy)
                    .WithMany(p => p.ItemsOrdereds)
                    .HasForeignKey(d => d.ToyId)
                    .HasConstraintName("FK__ItemsOrde__ToyID__4AB81AF0");
            });

            modelBuilder.Entity<ManufacturePlant>(entity =>
            {
                entity.HasKey(e => e.PlantId)
                    .HasName("PK__Manufact__98FE46BCF7ED935A");

                entity.ToTable("ManufacturePlant");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlantName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderedDate).HasColumnType("date");

                entity.Property(e => e.ToShipId).HasColumnName("ToShipID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__Customer__4316F928");

                entity.HasOne(d => d.ToShip)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ToShipId)
                    .HasConstraintName("FK__Orders__ToShipID__440B1D61");
            });

            modelBuilder.Entity<ToShipAddress>(entity =>
            {
                entity.HasKey(e => e.ToShipId)
                    .HasName("PK__ToShipAd__C87D0672A146854C");

                entity.ToTable("ToShipAddress");

                entity.Property(e => e.ToShipId).HasColumnName("ToShipID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ToShipAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__ToShipAdd__Custo__403A8C7D");
            });

            modelBuilder.Entity<Toy>(entity =>
            {
                entity.ToTable("Toy");

                entity.Property(e => e.ToyId).HasColumnName("ToyID");

                entity.Property(e => e.ToyName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToysPerPlant>(entity =>
            {
                entity.HasKey(e => e.TpId)
                    .HasName("PK__ToysPerP__FFF87F10521A27B5");

                entity.ToTable("ToysPerPlant");

                entity.Property(e => e.TpId).HasColumnName("TpID");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ToyId).HasColumnName("ToyID");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.ToysPerPlants)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("FK__ToysPerPl__Plant__3A81B327");

                entity.HasOne(d => d.Toy)
                    .WithMany(p => p.ToysPerPlants)
                    .HasForeignKey(d => d.ToyId)
                    .HasConstraintName("FK__ToysPerPl__ToyID__3B75D760");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
