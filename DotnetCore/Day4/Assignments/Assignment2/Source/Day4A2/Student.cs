using System;
using System.Collections.Generic;
using System.Text;

namespace Day4A2
{
    class Student
    {

        public static void tester(string name)
        {
           
            if (name.Length > 1)
            {
                throw new NameException("NAME CANNOT BE GREATER THAN ONE");
            }

            else
            {
                Console.WriteLine($"{name}, your name is valid");
            }
        }
        public static void handler(string name)
        {
            try
            {
                tester(name);
            }

            catch(NameException Ne)
            {
                Console.WriteLine(Ne.Message);
            }
        }
    }
}
