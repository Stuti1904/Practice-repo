using System;
using System.Collections.Generic;

namespace Day5Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Mobike newentry = new Mobike();
                newentry.Input();
                List<Mobike> newlist = new List<Mobike>();
                newlist.Add(newentry);
                foreach (var item in newlist)
                {
                    item.display();
                  
                }
                Console.WriteLine("DO YOU WANT SEARCH A ENTRY? IF YES PRESS S");
                char c = Convert.ToChar(Console.ReadLine());
                if(c=='s'|| c == 'S')
                {
                    Console.WriteLine("enter the bike number you want to search");
                    int searched = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(newlist.Find(x => x.BikeNumber == searched));

                }
                else {
                    Console.WriteLine("this is RAMBO RENTAL SERVICE");
                }
                Console.WriteLine("PRESS Y FOR ENTERING ANOTHER CUSTOMER OR N FOR EXITING");
                char ch = Convert.ToChar(Console.ReadLine());
                if(ch=='y'|| ch =='Y')
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
