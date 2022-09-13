using System;

namespace Day6A1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Func<double, double, double> area = new Func<double, double, double>((a, b) => a * b);
            Console.WriteLine("ENTER THE LENGTH OF THE RECTANGLE");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ENTER THE BREADTH OF THE RECTANGLE");
            double breadth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(area(length, breadth));

            
        }
    }
}
