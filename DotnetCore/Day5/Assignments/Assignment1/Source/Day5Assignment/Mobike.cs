using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Assignment
{
     public class Mobike
    {

        public  int BikeNumber;
        public string PhoneNumber;
        public  string CustomerName;
        public  int NumberOfDays;
        public  int charge = 0;
        public  void Input()
        {
            Console.WriteLine("ENTER YOUR BIKE NUMBER");
            BikeNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER YOUR  PHONE NUMBER");
            PhoneNumber = Console.ReadLine();
            Console.WriteLine("ENTER YOUR name");
            CustomerName = Console.ReadLine();
            Console.WriteLine("ENTER The number of days");
            NumberOfDays = Convert.ToInt32(Console.ReadLine());

        }

        public  void compute()
        {
            if (NumberOfDays <= 5)
            {
                charge = NumberOfDays * 500;
            }
            else if(NumberOfDays > 5 && NumberOfDays <=10){
                charge = 2500 + (NumberOfDays - 5) * 400;
            }
            else
            {
                charge = 2500 + 2000 + (NumberOfDays - 100) * 200;
            }
        }
        public  void display()
        {
            compute();
            Console.WriteLine(BikeNumber + "    " + PhoneNumber + "   " + NumberOfDays + "     " + charge);
        }


    }
}
