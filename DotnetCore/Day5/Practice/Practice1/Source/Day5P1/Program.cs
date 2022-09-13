using System;
using System.Collections.Generic;

namespace Day5P1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a list of integer type
            Console.WriteLine("ENTER THE NAMES OF 5 STUDENTS");
            List<string> Practice1 = new List<string>();
            Practice1.Add(Console.ReadLine());
            Practice1.Add(Console.ReadLine());
            Practice1.Add(Console.ReadLine());
            Practice1.Add(Console.ReadLine());
            Practice1.Add(Console.ReadLine());
            Console.WriteLine("THE NAMES OF THE STUDENTS ARE: ");
            foreach (var item in Practice1)
            {
                Console.WriteLine(item);
            }
            //if (Practice1.Contains("stuti"))
            //{
            //    Console.WriteLine("Found");
            //}
            Console.WriteLine("enter the index you want to search");
            int searched = Convert.ToInt32(Console.ReadLine());
            if (Practice1[searched] == null)
            {
                Console.WriteLine("INDEX NOT FOUND");
            }
            else
            {
                Console.WriteLine(Practice1[searched]);
            }
        }
    }
}
