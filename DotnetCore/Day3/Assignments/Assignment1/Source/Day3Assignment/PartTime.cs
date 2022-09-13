using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Assignment
{
    class PartTime:Employee
    {

        public int NumberOfHours;
        public int SalaryPerHour;
        public override void Get()
        {
            base.Get();

            Console.WriteLine("Enter Number Of Hours Worked: ");
            NumberOfHours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Salary Per Hour: ");
            SalaryPerHour = Convert.ToInt32(Console.ReadLine());
        }

        public override void display()
        {
            Console.WriteLine($"{Name}, {address}, Number of Hours: {NumberOfHours}, Salary Per Hour: {SalaryPerHour}, Total Salary : {Salary()}");
            Console.WriteLine("-----------------------------------------------------------------");
        }

        public override double Salary()
        {
            return NumberOfHours * SalaryPerHour;
        }
    }
}
