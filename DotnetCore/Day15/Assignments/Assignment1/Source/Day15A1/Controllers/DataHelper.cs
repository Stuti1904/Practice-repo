using Day15A1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day15A1.Controllers
{
    public class DataHelper
    {
        private NewDBContext context { get; set; }
        public DataHelper()
        {
            context = new NewDBContext();
        }

        public async Task<List<EmployeeFifteen>> GetEmployees()
        {
            var emps = await (from emp in context.EmployeeFifteens
                              select emp).ToListAsync();
            return emps;
        }
        public async Task<EmployeeFifteen> GetEmployee(int id)
        {
            var employee = await (from emp in context.EmployeeFifteens
                                  where emp.EmployeeId == id
                                  select emp).SingleAsync();
            return employee;
        }
        public async Task<EmployeeFifteen> AddEmployee(EmployeeFifteen employee)
        {
            context.Add(employee);
           await context.SaveChangesAsync();
            return employee;
        }
        public async Task<EmployeeFifteen> UpdateEmployee(EmployeeFifteen employee)
        {
            context.Update(employee);
            await context.SaveChangesAsync();
            return employee;
        }

        public async Task<string> DeleteEmployee(int id)
        {
            var todelete = await GetEmployee(id);
            context.EmployeeFifteens.Remove(todelete);
             await context.SaveChangesAsync();
            return "DELETED";
        }
        public List<Assignment> GetAssignmentByEmployee(int id1, int id2)
        {
            var assignment = (from temp in context.Assignments
                              where temp.EmployeeId == id1 && temp.AssignmentId == id2
                              select temp).ToList();
            return assignment;
        }
    }
}
