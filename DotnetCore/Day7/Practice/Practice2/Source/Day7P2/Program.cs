using System;
using System.Collections.Generic;
using System.Linq;

namespace Day7P2
{
    class Program
    {
        static void Main(string[] args)
        {
            //join 
            List<Student> studentList = new List<Student>()
            {
                 new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
    new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
    new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
    new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
    new Student() { StudentID = 5, StudentName = "Ron"  }
            };

            List<Standard> standards = new List<Standard>()
            {
                 new Standard(){ StandardID = 1, StandardName="Standard 1"},
    new Standard(){ StandardID = 2, StandardName="Standard 2"},
    new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };

            var innerjoin = studentList.Join(

                standards,
                studentList => studentList.StandardID,
                standards => standards.StandardID,
                (studentlist, standards) => new
                {

                    studentName = studentlist.StudentName,
                    StandardName = standards.StandardName
                }
                    );


            foreach (var item in innerjoin)
            {
                Console.WriteLine(item);
            }

            //groupjoin
            var groupJoin = standards.GroupJoin(studentList,
                std => std.StandardID,
                s => s.StandardID,
                (std, studentList) => new
                {
                    students = studentList,
                    standards = std.StandardName
                });

            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.standards);
                foreach (var i in item.students)
                {
                    Console.WriteLine(i.StudentName);
                }
            }
        }
    }
}
