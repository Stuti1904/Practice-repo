using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Day11Assignment.Models
{
    public partial class HospitalContext : DbContext
    {
        public HospitalContext()
        {
        }

        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<HealthCareAssistant> HealthCareAssistants { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PC0753\\MSSQL2019;Database=Hospital;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DoctorName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Speciality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Doctors)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__Doctors__Departm__38996AB5");
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.Property(e => e.DrugId).HasColumnName("DrugID");

                entity.Property(e => e.DrugName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HealthCareAssistant>(entity =>
            {
                entity.HasKey(e => e.Hcid)
                    .HasName("PK__HealthCa__02F04230EF9EFDD0");

                entity.ToTable("HealthCareAssistant");

                entity.Property(e => e.Hcid).HasColumnName("HCID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Hcname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HCName");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.HealthCareAssistants)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__HealthCar__Depar__3B75D760");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.Disease)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.Hcid).HasColumnName("HCID");

                entity.Property(e => e.PatientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK__Patients__Doctor__403A8C7D");

                entity.HasOne(d => d.Hc)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.Hcid)
                    .HasConstraintName("FK__Patients__HCID__412EB0B6");
            });

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Prescription");

                entity.Property(e => e.DrugId).HasColumnName("DrugID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.PrescriptionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PrescriptionID");

                entity.HasOne(d => d.Drug)
                    .WithMany()
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK__Prescript__DrugI__440B1D61");

                entity.HasOne(d => d.Patient)
                    .WithMany()
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__Prescript__Patie__4316F928");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
