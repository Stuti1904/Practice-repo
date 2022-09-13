using System;
using System.Threading.Tasks;

namespace Day9P1
{
  public static  class Program
    {

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("METHOD 1");
                    Task.Delay(100).Wait();
                }

            });
        }
        public static void Method2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("METHOD 2");
                Task.Delay(100).Wait();
            }

        }

        static void Main(string[] args)
        {
            _ = Method1();
            Method2();
        }
    }
}
