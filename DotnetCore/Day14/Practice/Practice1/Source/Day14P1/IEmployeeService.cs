using Day14P1.Controllers;
using Day14P1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day14P1
{
    public interface IEmployeeService : Irepository<Employee>
    {
        Employee Add(DemoEmployee employee);
    }
    public class EmployeeService : Repository<Employee>, IEmployeeService
    {
        public EmployeeService(RevisionDBContext demoDbContext) : base(demoDbContext)
        {
        }
        public Employee Add(Employee employee)
        {
            base.Add(employee);
            return employee;
        }

        public Employee Add(DemoEmployee employee)
        {
            throw new NotImplementedException();
        }
    }
}

