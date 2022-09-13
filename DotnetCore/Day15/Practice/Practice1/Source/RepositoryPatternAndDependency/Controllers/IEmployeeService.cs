using RepositoryPatternAndDependency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPatternAndDependency.Controllers
{
   public interface IEmployeeService : IRepository<DemoEmployee>
    {
        DemoEmployee Add(DemoEmployee employees);
        DemoEmployee UpdateEmployee(int id, DemoEmployee employee);
    }
    public class EmployeeService : Repository<DemoEmployee>, IEmployeeService
    {


        public EmployeeService(RevisionDBContext context) : base(context)
        {

        }
        public DemoEmployee Add(DemoEmployee employees)
        {
            base.Add(employees);
            return employees;
        }
 
        public List<DemoEmployee> GetEmployees()
        {
           var emp= base.GetAllEmployees();
            return emp;
        }
        public DemoEmployee GetEmployee(int id)
        {
            var particularemp = base.GetByID(id);
            return particularemp;
        }
        public DemoEmployee UpdateEmployee(int id, DemoEmployee employee)
        {
            var updatedemployee = base.GetByID(id);

            updatedemployee.EmpName = employee.EmpName;
            updatedemployee.EmpSalary = employee.EmpSalary;
            base.Update(updatedemployee);
            return updatedemployee;
        }
        public string DeleteEmployee(int id)
        {
            base.Delete(id);
            return "DELETED";
        }
    }
}
