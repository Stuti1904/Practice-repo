using System;

namespace Day6P3
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATING FUNC DELEGATES
            Func<int, int, int> func = new Func<int, int, int>((a, b) => a + b);
            Console.WriteLine(func(10, 20));

            //OR WE CAN USE LAMBDA FUNCTION

            Func<int, int, int> add = (int num1, int num2) => { return num1 + num2; };
            Console.WriteLine(add(10, 20));
        }
    }
}
