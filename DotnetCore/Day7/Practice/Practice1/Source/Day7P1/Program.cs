using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7P1
{
    class Program
    {

        
        static void Main(string[] args)
        {

            //where condition
            List<Student> studentlist = new List<Student>()
           {
               new Student(){studentId=1, studentName="John", age=18},
               new Student() { studentId = 2, studentName = "Moin",  age = 20 } ,
        new Student() { studentId = 3, studentName = "Bill",  age = 18 } ,
        new Student() { studentId = 4, studentName = "Ram" , age = 20} ,
        new Student() { studentId = 5, studentName = "Ron" , age = 18 }
           };

            var teenstudents = from s in studentlist
                               where s.age > 12 && s.age < 20
                               select s;
           
            foreach (var item in teenstudents)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------WHERE CONDITION-----------");
            var namestudents = from b in studentlist
                               where b.studentName == "John"
                               select b;
            foreach (var item in namestudents)
            {
                Console.WriteLine(item);
            }

            //order by

            Console.WriteLine("------ORDERED BY-----------");
            var ordered = from s in studentlist
                          orderby s.studentName //descending
                          select s;
            foreach (var item in ordered)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------GROUP BY-----------");
            var groupby = from s in studentlist
                          group s by s.age into studentage
                          select studentage;
            foreach (var item in groupby)
            {
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
