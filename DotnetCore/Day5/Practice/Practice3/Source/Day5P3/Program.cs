using System;
using System.Collections.Generic;

namespace Day5P3
{
    class Program
    {
        static void Main(string[] args)
        {
            //create dictionary with the key value as string and value as int
            Dictionary<string, int> Product = new Dictionary<string, int>();

            Console.WriteLine("enter the number of products you want");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the product information in the following format: productname price");
            for (int i = 0; i < number; i++)
            {
                Product.Add(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("enter the product you want to search");
            string searched = Console.ReadLine();
            if (Product.ContainsKey(searched))
            {
                Console.WriteLine($" You have found your match {searched} and the price is {Product[searched]}");
            }
            else
            {
                Console.WriteLine("NOT FOUND");
            }

            Console.WriteLine("Press any key to terminate");

            Console.ReadKey();
        }
    }
}
