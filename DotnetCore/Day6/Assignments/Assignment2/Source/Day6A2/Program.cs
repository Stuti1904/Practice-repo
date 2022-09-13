using System;

namespace Day6A2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addDelegate = (int a, int b) => { return a + b; };
            Console.WriteLine("ENTER THE FIRST NUMBER");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE SECOND NUMBER");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(addDelegate(first, second));
        }
    }
}
