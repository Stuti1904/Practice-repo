using System;
using System.Collections.Generic;
using System.Text;

namespace Day7P1
{
    class Student
    {

        public int studentId { get; set; }

        public string studentName { get; set; }

        public int age { get; set; }

        public override string ToString()
        {
            return studentId +"  "+ studentName + "  "  + age;
        }
    }
}
