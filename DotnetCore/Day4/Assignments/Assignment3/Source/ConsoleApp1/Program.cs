using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the date");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the year");
            int year = Convert.ToInt32(Console.ReadLine());

            var generateddate = new DateTime(year, month, date);

            TesterClass.tester(generateddate);
        }
    }
}
