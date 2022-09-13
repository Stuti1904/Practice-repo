using EntityPractice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //simply using join
            var context = new RevisionDBContext();

            Console.WriteLine("------------------USING JOIN---------------------");
            var emps = context.EmployeeDTOs.FromSqlRaw<EmployeeDTO>("exec GetEmployee").ToList();
            foreach (var item in emps)
            {
                Console.WriteLine(item.EmpId + "  " + item.EmpName + "  " + item.EmpSalary + "  " + item.DepartmentName);
            }

            Console.WriteLine("----------------------SIMPLY PRINTING THE DATA FROM TABLES-------------------");

            var meals = context.Meals.ToList();
            foreach (var item in meals)
            {
                Console.WriteLine(item.Mealid + "  " + item.Mealname);
            }

            Console.WriteLine("------------------USING WHERE------------------------------");
            Console.WriteLine("ENTER THE MEAL ID YOU WANT TO EAT");
            var toeat = Convert.ToInt32(Console.ReadLine());
            var particularmeal = context.Meals.Where(s => s.Mealid == toeat).ToList();
            foreach (var item in particularmeal)
            {
                Console.Write(item.Mealid + "  " + item.Mealname);
            }

            Console.WriteLine("---------INSERT A VALUE IN TABLE---------------");

            var emp = new DemoEmployee();
            Console.WriteLine("enter employee id");
            emp.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            emp.EmpName = Console.ReadLine();
            Console.WriteLine("enter department id");
            emp.DepartmentId = Convert.ToInt32(Console.ReadLine());

            context.DemoEmployees.Add(emp);
            context.SaveChanges();
            Console.WriteLine("CHANGES SAVED");

            Console.WriteLine("-----------------------INSERTING VALUES IN PARENT AND CHILD USING ONE SINGLE STATEMENT---------------------");

            var dept = new Department();
            dept.DepartmentId = 2;
            dept.DepartmentName = "management";

            var empl = new DemoEmployee();
            empl.EmpId = 7;
            empl.EmpName = "ac";
            empl.EmpSalary = 6000;

            context.Departments.Add(dept);
            context.Add(dept);
            dept.DemoEmployees.Add(empl);
            context.SaveChanges();
            Console.WriteLine("DONE");

            Console.WriteLine("------------------------UPDATE EMPLOYEES--------------------");
            Console.WriteLine("Enter the id of the employee you want to update");
            var tosearch = Convert.ToInt32(Console.ReadLine());
            var em = context.DemoEmployees.Where(x => x.EmpId == tosearch).FirstOrDefault();
            Console.WriteLine("enter the changed name");
            em.EmpName = Console.ReadLine();
            context.Update(em);
            context.SaveChanges();

            Console.WriteLine("----------------DELETE AN EMPLOYEE--------------------------");
            Console.WriteLine("enter the employee id whom you want to delete");
            var todelete = Convert.ToInt32(Console.ReadLine());
            var emd = context.DemoEmployees.Where(x => x.EmpId == todelete).FirstOrDefault();
            context.Remove(emd);
            context.SaveChanges();
        }
    }
}
