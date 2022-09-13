using System;
using System.Collections.Generic;

namespace Day5P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> agestack = new Stack<int>();
            Console.WriteLine("enter the amount of elements you want");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("enter the next age");
                agestack.Push(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var item in agestack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
