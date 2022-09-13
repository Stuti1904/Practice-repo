using System;
using System.Threading.Tasks;

namespace Day9P2
{
  public static  class Program
    {

        public static void CallMethod()
        {
           int task =  Method1();
            Method2();
            int counter =task;
            Method3(counter);
        }

         static void Method3(int count)
        {
            Console.WriteLine("total count is "+ count);
        }

         static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("METHOD 2");
            }
        }

        static int Method1()
        {
            int count=0;
                for (int i = 0; i < 100; i++)
                {
                    count++;
                }
            return count;
        }

        static void Main(string[] args)
        {
            CallMethod();
        }
    }
}
