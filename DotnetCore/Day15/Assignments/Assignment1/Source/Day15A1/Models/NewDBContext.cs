using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Day15A1.Models
{
    public partial class NewDBContext : DbContext
    {
        public NewDBContext()
        {
        }

        public NewDBContext(DbContextOptions<NewDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeFifteen> EmployeeFifteens { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<JobHistory> JobHistories { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<ViewFive> ViewFives { get; set; }
        public virtual DbSet<ViewFour> ViewFours { get; set; }
        public virtual DbSet<ViewOne> ViewOnes { get; set; }
        public virtual DbSet<ViewThree> ViewThrees { get; set; }
        public virtual DbSet<ViewTwo> ViewTwos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PC0753\\MSSQL2019;Database=NewDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");

                entity.Property(e => e.ActionCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ActionReasonCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ActualTerminationDate).HasColumnType("date");

                entity.Property(e => e.AssignmentCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentName)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentProjectEndDate).HasColumnType("date");

                entity.Property(e => e.AssignmentStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AssignmentTypeId).HasColumnName("AssignmentTypeID");

                entity.Property(e => e.BusinessUnitId).HasColumnName("BusinessUnitID");

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.DefaultExpenseAccount)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EffectiveEndDate).HasColumnType("date");

                entity.Property(e => e.EffectiveStartDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.GradeLadderId).HasColumnName("GradeLadderID");

                entity.Property(e => e.LegalEntityId).HasColumnName("LegalEntityID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ManagerAssignmentId).HasColumnName("ManagerAssignmentID");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Assignmen__Emplo__5EBF139D");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("departments");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("DEPARTMENT_ID")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_NAME");

                entity.Property(e => e.LocationId)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("LOCATION_ID");

                entity.Property(e => e.ManagerId)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("MANAGER_ID");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employees");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("EMPLOYEE_ID")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CommissionPct)
                    .HasColumnType("decimal(2, 2)")
                    .HasColumnName("COMMISSION_PCT");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.HireDate)
                    .HasColumnType("date")
                    .HasColumnName("HIRE_DATE");

                entity.Property(e => e.JobId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JOB_ID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.ManagerId)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("MANAGER_ID");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NUMBER");

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("SALARY");
            });

            modelBuilder.Entity<EmployeeFifteen>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__Employee__7AD04FF1421975AA");

                entity.ToTable("EmployeeFifteen");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CitizenShipId).HasColumnName("CitizenShipID");

                entity.Property(e => e.CitizenshipLegislationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CitizenshipStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CitizenshiptoDate).HasColumnType("date");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorrespondanceLanguage)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DriversLicenseExpiryDate).HasColumnType("date");

                entity.Property(e => e.DriversLicenseId).HasColumnName("DriversLicenseID");

                entity.Property(e => e.DriversLicenseIssuingCountry)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveStartDate).HasColumnType("date");

                entity.Property(e => e.Ethinicity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HomeFaxCountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhoneCountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HomePhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Honors)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaritialStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MilitaryVetStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NationalId).HasColumnName("NationalID");

                entity.Property(e => e.NationalIdcountry)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NationalIDCountry");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("jobs");

                entity.Property(e => e.JobId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JOB_ID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("JOB_TITLE");

                entity.Property(e => e.MaxSalary)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("MAX_SALARY");

                entity.Property(e => e.MinSalary)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("MIN_SALARY");
            });

            modelBuilder.Entity<JobHistory>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.StartDate })
                    .HasName("PK__job_hist__6734C998A349DFD3");

                entity.ToTable("job_history");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("START_DATE");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("END_DATE");

                entity.Property(e => e.JobId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("JOB_ID");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("locations");

                entity.Property(e => e.LocationId)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("LOCATION_ID")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.CountryId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY_ID");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("POSTAL_CODE");

                entity.Property(e => e.StateProvince)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("STATE_PROVINCE");

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("STREET_ADDRESS");
            });

            modelBuilder.Entity<ViewFive>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewFive");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_NAME");

                entity.Property(e => e.HireDate)
                    .HasColumnType("date")
                    .HasColumnName("HIRE_DATE");

                entity.Property(e => e.ManagerName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("MANAGER_NAME");

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(8, 2)")
                    .HasColumnName("SALARY");
            });

            modelBuilder.Entity<ViewFour>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewFour");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_NAME");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");
            });

            modelBuilder.Entity<ViewOne>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewOne");

                entity.Property(e => e.DepartmentId)
                    .HasColumnType("decimal(4, 0)")
                    .HasColumnName("DEPARTMENT_ID");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_NAME");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("JOB_TITLE");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("NAME");
            });

            modelBuilder.Entity<ViewThree>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewThree");

                entity.Property(e => e.DateDiff).HasColumnName("DATE_DIFF");

                entity.Property(e => e.EmployeeId)
                    .HasColumnType("decimal(6, 0)")
                    .HasColumnName("EMPLOYEE_ID");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(35)
                    .IsUnicode(false)
                    .HasColumnName("JOB_TITLE");
            });

            modelBuilder.Entity<ViewTwo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewTwo");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("DEPARTMENT_NAME");

                entity.Property(e => e.NoOfEmployees).HasColumnName("No of Employees");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
