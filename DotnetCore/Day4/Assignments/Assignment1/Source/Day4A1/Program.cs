using System;

namespace Day4A1
{
    class Program
    {

        public static void TestAge(int age)
        {
            if (age < 0)
            {
                throw new AgeException("AGE CANNOT BE NEGATIVE");
            }
        }
        static void Main(string[] args)
        {
            // we will test user defined age exception class we have created

            try
            {
                TestAge(-1);
            }
            catch(AgeException AE)
            {
                Console.WriteLine(AE);
            }
        }
    }
}
