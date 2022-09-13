using System;
using System.Collections.Generic;
using System.Text;

namespace Day3Assignment
{
    abstract class Employee: Emp
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string address { get; set; }

        public string PanNumber { get; set; }

        public virtual void display()
        {
            Console.WriteLine(ID + "  " + Name + "  " + address + "  " + PanNumber);
        }
        public virtual void Get()
        {
            Console.WriteLine("Enter EmployeeID:");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Address:");
            address = Console.ReadLine();

            Console.WriteLine("Enter PAN Number:");
            PanNumber = Console.ReadLine();
        }

        public abstract double Salary();

        
        
    }
}
