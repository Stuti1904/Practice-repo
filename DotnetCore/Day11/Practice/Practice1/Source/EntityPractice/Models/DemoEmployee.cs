using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace EntityPractice.Models
{
    public partial class DemoEmployee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal? EmpSalary { get; set; }
        public DateTime? JoiningDate { get; set; }
        public int? DepartmentId { get; set; }
        public int? ManagerId { get; set; }

        public virtual Department Department { get; set; }
    }

    public class EmployeeDTO
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal? EmpSalary { get; set; }
        public DateTime? JoiningDate { get; set; }
        public int? DepartmentId { get; set; }
        public int? ManagerId { get; set; }

        public string DepartmentName { get; set; }
    }
}
