using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day14P1.Models;
using Microsoft.EntityFrameworkCore;

namespace Day14P1
{
    public class DataHelper
    {
    public RevisionDBContext context { get; set; }
        public DataHelper()
        {
            context = new RevisionDBContext();
        }

        public async Task<List<DemoEmployee>> GetDemoEmployees()
        {
            var em = await (from emp in context.DemoEmployees
                          
                            select new DemoEmployee
                            {
                                EmpId = emp.EmpId,
                                EmpName = emp.EmpName,
                                DepartmentId = emp.DepartmentId
                            }).ToListAsync();
            return em;
        }
        public async Task <DemoEmployee> GetEmployee(int id)
        {
            var employee = await (from emp in context.DemoEmployees
                                  where emp.EmpId == id
                                  select new DemoEmployee
                                  {
                                      EmpId = emp.EmpId,
                                      EmpName = emp.EmpName,
                                      DepartmentId = emp.DepartmentId
                                  }).SingleAsync();
            return employee;
        }
        public async Task<int> AddEmployee(DemoEmployee demo)
        {
            context.Add(demo);
            await context.SaveChangesAsync();
            return demo.EmpId;
        }
        public async Task<int> UpdateEmployee(DemoEmployee employee)
        {
            context.Update(employee);
            await context.SaveChangesAsync();
            return employee.EmpId;
        }
        public async Task<DemoEmployee> Get(int id)
        {
            return await context.DemoEmployees.Where(x => x.EmpId == id).FirstOrDefaultAsync();
        }
        public async Task<int> DeleteEmployee(int id)
        {
            var todelete = await Get(id);
            context.DemoEmployees.Remove(todelete);
            context.SaveChanges();
            return 1;
        }
    }
}
