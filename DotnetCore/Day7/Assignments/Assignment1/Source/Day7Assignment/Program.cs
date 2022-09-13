using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> Employees = new List<Employees>() { 
                new Employees() { ID = 1, FirstName ="John", LastName ="Abraham", salary = 1000000, JoiningDate = new DateTime(2013, 1, 1), Department ="Banking"}, 
                new Employees() { ID = 2, FirstName ="Michael", LastName ="Clarke", salary = 800000, JoiningDate = new DateTime(), Department ="Insurance" }, 
                new Employees() { ID = 3, FirstName ="oy", LastName ="Thomas", salary = 700000, JoiningDate = new DateTime(), Department ="Insurance"}, 
                new Employees() { ID = 4, FirstName ="Tom", LastName ="Jose", salary = 600000, JoiningDate = new DateTime(), Department ="Banking"}, 
                new Employees() { ID = 4, FirstName ="TestName2", LastName ="Lname %", salary = 600000, JoiningDate = new DateTime(2013, 1, 1), Department ="Services"} }; 
            List<Incentive> incentives = new List<Incentive>() { 
                new Incentive() { ID = 1, IncentiveAmount = 5000, IncentiveDate = new DateTime(2013, 02, 02) }, 
                new Incentive() { ID = 2, IncentiveAmount = 10000, IncentiveDate = new DateTime(2013, 02, 4) }, 
                new Incentive() { ID = 1, IncentiveAmount = 6000, IncentiveDate = new DateTime(2012, 01, 5) }, 
                new Incentive() { ID = 2, IncentiveAmount = 3000, IncentiveDate = new DateTime(2012, 01, 5) } };


            Console.WriteLine("--------------------FIND THE EMPLOYEES WHOSE FIRST NAME IS JOHN-------------------");
            var particularname = from e in Employees
                                 where e.FirstName == "John"
                                 select e;
            foreach (var item in particularname)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------PRINTING ONLY FIRST AND LAST NAMES OF THE EMPLOYEES---------------------------------");

            var onlynames = from e in Employees
                                 select e;

            foreach (var item in onlynames)
            {
                Console.WriteLine(item.FirstName + item.LastName);
            }

            Console.WriteLine("-----------------INCENTIVE AMOUNT AND FIRST NAMES-------------------------------");

            var empin = Employees.Join(incentives,
                employees => employees.ID,
                incentives => incentives.ID,
                (employee, incentive) => new
                {
                    employee = employee.FirstName,
                    incentive = incentive.IncentiveAmount
                }


                );

            foreach (var item in empin)
            {
                Console.WriteLine(item.employee + "   " + item.incentive);
            }

            var deptMaxSalary = from emp in Employees
                                group emp by emp.Department into deptGroup
                                let maxSalary = deptGroup.Max(x => x.salary)
                                orderby maxSalary
                                select maxSalary;
            Console.WriteLine("--------------------DEPARTMENT WISE MAX SALARY------------------------");
            foreach (var coll in deptMaxSalary)
            {
                Console.WriteLine(coll);
            }

            var dept = from emp in Employees
                       group emp by emp.Department into department
                       let totalsalary = department.Sum(x => x.salary)
                       where totalsalary > 800000
                       select totalsalary;
            Console.WriteLine("--------------------TOTAL SALARY IS GREATER THAN 8,00,000------------------------");
            foreach (var item in dept)
            {
                Console.WriteLine(item);
            }

        }
    }
}
