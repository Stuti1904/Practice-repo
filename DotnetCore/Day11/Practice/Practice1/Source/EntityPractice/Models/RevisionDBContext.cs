using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EntityPractice.Models
{
    public partial class RevisionDBContext : DbContext
    {
        public RevisionDBContext()
        {
        }

        public RevisionDBContext(DbContextOptions<RevisionDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DemoEmployee> DemoEmployees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }
        public virtual DbSet<Meal> Meals { get; set; }
        public virtual DbSet<ProductList> ProductLists { get; set; }
        public virtual DbSet<UpdatedList> UpdatedLists { get; set; }
        public virtual DbSet<EmployeeDTO> EmployeeDTOs{ get;  set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PC0753\\MSSQL2019;Database=RevisionDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<DemoEmployee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__DemoEmpl__AF2DBA794196A6B8");

                entity.ToTable("DemoEmployee");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmpID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpSalary).HasColumnType("money");

                entity.Property(e => e.JoiningDate).HasColumnType("date");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DemoEmployees)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__DemoEmplo__Depar__38996AB5");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Drink>(entity =>
            {
                entity.ToTable("DRINKS");

                entity.Property(e => e.Drinkid)
                    .ValueGeneratedNever()
                    .HasColumnName("DRINKID");

                entity.Property(e => e.Drinkname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DRINKNAME");
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.ToTable("MEAL");

                entity.Property(e => e.Mealid)
                    .ValueGeneratedNever()
                    .HasColumnName("MEALID");

                entity.Property(e => e.Mealname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MEALNAME");
            });

            modelBuilder.Entity<ProductList>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__PRODUCT___A3420A77A88AB66F");

                entity.ToTable("ProductList");

                entity.Property(e => e.Pid).ValueGeneratedNever();

                entity.Property(e => e.Pname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PName");

                entity.Property(e => e.Pprice).HasColumnType("money");
            });

            modelBuilder.Entity<UpdatedList>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK__UPDATED___A3420A773F0975A3");

                entity.ToTable("UpdatedList");

                entity.Property(e => e.PId)
                    .ValueGeneratedNever()
                    .HasColumnName("P_ID");

                entity.Property(e => e.PName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("P_NAME");

                entity.Property(e => e.PPrice)
                    .HasColumnType("money")
                    .HasColumnName("P_PRICE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
