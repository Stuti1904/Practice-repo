using System;

namespace Assignments
{
    class Program
    {
        enum days
        {
            Sunday,
            Monday,
            Tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }
        static void Main(string[] args)
        {
            //ASSIGNMENT QUESTION 1 TO PRINT THE SUM OF ALL EVEN NUMBERS FROM 1 TO THE NUMBER USER SPECIFIES

           int limit = 0;
            int sum = 0;
            Console.WriteLine("ENTER THE UPPER BOUND OF THIS CALCULATION");
           limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("THE SUM OF ALL THE NUMBERS BETWEEN 1 AND " + limit + "IS: ");
           for(int i=1; i<=limit; i++)
            {
               if (i % 2 == 0)
           {
              sum = sum + i;
            }
          }
          Console.WriteLine(sum);


            //ASSIGNMENT QUESTION 2 TO Store your name in one string and find out how many vowel characters are there in your name

            String str = "Stuti";
           int count = 0;
       Console.WriteLine("WE ARE GOING TO FIND OUT THE NUMBER OF VOWELS IN MY NAME:" + str);
        for(int i=0; i < str.Length; i++)
          {
             if(str[i]=='a'|| str[i]=='A'|| str[i] == 'e' || str[i] == 'E' || str[i] == 'i' || str[i] == 'I' || str[i] == 'o' || str[i] == 'O' || str[i] == 'u' || str[i] == 'U')
             {
       count++;
          }
            }
          Console.WriteLine($"the number of vowels in {str} is {count}");

          //ASSIGNMENT QUESTION 3 Create a weekday enum and accept week day number and display week day.
         Console.WriteLine("Enter a Weekday number: ");
         int day = Convert.ToInt32(Console.ReadLine());
       days str1 = (days)day;

        Console.WriteLine( + day + " is " + str1);
         

            //ASSIGNMENT QUESTION 4 Accept 10 student Name,Address,Hindi,English,Maths Marks ,do the total and compute Grade. Note do it with Array and display the result in grid format

            StudentDetail[] student = new StudentDetail[10];
          for(int i=0; i<10; i++)
            {
                StudentDetail temp = new StudentDetail();
                Console.WriteLine("enter name");
                temp.name = Console.ReadLine();
                Console.WriteLine("enter address");
                temp.address = Console.ReadLine();
                Console.WriteLine("enter hindi marks");
                temp.hindi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter english marks");
                temp.enlgish = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter math marks");
                temp.math = Convert.ToInt32(Console.ReadLine());
                student[i]= temp;
            }
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("name  address  hindi  english  math  total  grade");
            Console.WriteLine("--------------------------------------------------------------------");
            for(int i=0; i<10; i++)
            {
                Console.Write(student[i].name + "  ");
                Console.Write(student[i].address + "  ");
                Console.Write(student[i].hindi + "  ");
                Console.Write(student[i].enlgish + "  ");
                Console.Write(student[i].math + "  ");
                Console.Write(student[i].total + "  ");
                Console.Write(student[i].grade + "  ");
                Console.WriteLine("                                                                ");
            }
            
            //ASSIGNMENT QUESTION 5 Accept Age from user, if age is more than 18 eligible for vote otherwise it should be displayed as not eligible. Do it with ternary operato

            int age = 0;
            Console.WriteLine("enter you age please");
            age = Convert.ToInt32(Console.ReadLine());
           String result( int age)=> age > 18 ? "ELIGIBLE FOR VOTING" :"NOT ELIGIBLE FOR VOTING";
            Console.WriteLine(result(age));
        }

    }
}
