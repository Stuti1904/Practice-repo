using System;

namespace Day9ExtensionMethods
{
     public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            int i = s.WordCount();
            Console.WriteLine(i);
        }
    }
}
