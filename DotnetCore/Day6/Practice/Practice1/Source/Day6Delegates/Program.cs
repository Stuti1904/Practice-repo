using System;

namespace Day6Delegates
{
    class Program
    {
        public delegate void Del(string message);

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Del del1 = DelegateMethod;
            string name = "stuti shahu";
            del1($" my name is {name}");
        }
    }
}
