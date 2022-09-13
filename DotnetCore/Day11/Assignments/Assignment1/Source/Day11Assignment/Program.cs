using System;

namespace Day11Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DataHelper dh = new DataHelper();
            Console.WriteLine("INSERTING A DOCTOR");
            dh.InsertDoctor();
            Console.WriteLine("UPDATE A DOCTOR");
            dh.UpdateDoctor();
            Console.WriteLine("DELETING A DOCTOR");
            dh.DeleteDoctor();
            Console.WriteLine("PATIENT UNDER A DOCTOR");
            dh.getpatientreport();
            Console.WriteLine("prescription of a patient");
            dh.getprescription();
        }
    }
}
