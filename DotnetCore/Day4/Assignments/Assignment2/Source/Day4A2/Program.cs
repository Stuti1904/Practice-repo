using System;

namespace Day4A2
{
    class Program
    {

        static void Main(string[] args)
        {
            string name = "";
            Console.WriteLine("ENTER YOUR NAME");
            name = Console.ReadLine();
            Student.handler(name);
        }
    }
}
