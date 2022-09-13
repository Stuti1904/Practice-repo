using System;

namespace Day3Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Emp = new PartTime();
            Console.WriteLine("ENTER 1 IF YOU ARE PART TIMER. 2 IF YOU ARE FULL TIMER");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Part Time Employee Details: \n -----------------------------------------------");
                  Emp.Get();
                   Emp.display();
                    break;
                case 2:
                    Console.WriteLine("Full Time Employee Details: \n -----------------------------------------------");
                    Emp = new FullTime();
                    Emp.Get();
                    Emp.display();
                    break;
                default:
                    Console.WriteLine("INVALID CHOICE");

                    break;
            }
            
            
        }
    }
}
