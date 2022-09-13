using System;
using System.IO;

namespace DirectoryInfoPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //directoryinfo

            DirectoryInfo di = new DirectoryInfo(@"C:\Users\stuti.shahu\Desktop\Training\2445-Stuti-Feb22\.NetCore\Day10\Practice\Practice2\Source\DirectoryInfoPractice ");
            di.Create();
            Console.WriteLine(di.Parent);
            foreach (var item in di.GetDirectories())
            {
                Console.WriteLine(item.FullName);
            }
        }
    }
}
