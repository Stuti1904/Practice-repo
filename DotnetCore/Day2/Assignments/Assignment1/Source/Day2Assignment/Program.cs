using System;

namespace Day2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[5];
            Console.WriteLine("ENTER THE DETAILS OF 5 PEOPLE IN THE FOLLOWING PATTERN");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter the firstname");
                var fname = Console.ReadLine();
                Console.WriteLine("enter the lastname");
                var lname = Console.ReadLine();
                Console.WriteLine("enter the email");
                var email = Console.ReadLine();
                Console.WriteLine("enter the date of your date of brithdate");
                var date = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the month of your date of brithdate");
                var month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the year of your date of brithdate");
                var year = Convert.ToInt32(Console.ReadLine());
                Person tempPerson = new Person(fname, lname, email, new DateTime(year, month, date));
                people[i] = tempPerson;
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("FIRSTNAME" + "  " + "LASTNAM" + "  " + "EMAIL" + "  " + "DATEOFBIRTH" + "  " + "ZODAIC" + "  " + "CHINESE ZODAIC" + "  " + "ADULT" + "  " + "BIRTHDAY TODAY?" + "  " + "USERNAME" + "  ");
            Console.WriteLine("-----------------------------------------------------------");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(people[i].FirstName + "  ");
                Console.Write(people[i].LastName + "  ");
                Console.Write(people[i].Email + "  ");
                Console.Write(people[i].DateOfBirth + "  ") ;
                Console.Write(people[i].Zodiac + "  ");
                Console.Write(people[i].ChineseZodaic + "  ");
                Console.Write(people[i].IsAdult + "  ");
                Console.Write(people[i].IsBirthdayToday + "  ");
                Console.Write(people[i].UserName + "  ");
                Console.WriteLine("                                          ");
            }
               

        }
    }
}
