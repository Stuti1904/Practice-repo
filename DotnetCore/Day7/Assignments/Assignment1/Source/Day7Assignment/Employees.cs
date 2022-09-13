using System;
using System.Collections.Generic;
using System.Text;

namespace Day7Assignment
{
    class Employees
    {
        public static object firstname { get; internal set; }
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double salary { get; set; }

        public DateTime JoiningDate { get; set; }

        public string Department { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + "  " + salary + "  " + JoiningDate + "  " + Department;
        }
    }
}
