using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Day11Assignment.Models;

namespace Day11Assignment
{
    class DataHelper
    {
        private HospitalContext context { get; set; }
        public DataHelper()
        {
            context = new HospitalContext();
        }
        public void InsertDoctor()
        {
            var doc = new Doctor();
            Console.WriteLine("ENTER DOCTOR'S NAME");
            doc.DoctorName = Console.ReadLine();
            Console.WriteLine("ENTER DOCTOR SPECIALITY");
            doc.Speciality = Console.ReadLine();
            Console.WriteLine("ENTER THE DEPARTMENT OF THE DOCTOR");
            doc.DepartmentId = Convert.ToInt32(Console.ReadLine());

            context.Doctors.Add(doc);
            context.SaveChanges();

        }

        public void UpdateDoctor()
        {
            
            Console.WriteLine("ENTER THE ID OF THE DOCTOR YOU WANT TO UPDATE");
            var docid = Convert.ToInt32(Console.ReadLine());
            var doc = context.Doctors.Where(x => x.DoctorId == docid).FirstOrDefault();
            doc.Speciality = "hhhhh";
            context.SaveChanges();

            context.Doctors.Update(doc);
            context.SaveChanges();

        }

        public void DeleteDoctor()
        {
            Console.WriteLine("ENTER THE ID OF THE DOCTOR YOU WANT TO DELETE");
            var todelete = Convert.ToInt32(Console.ReadLine());
            var doc = context.Doctors.Where(x => x.DoctorId == todelete).ToList();
            context.Remove(doc);
            context.SaveChanges();
        }

        public void getpatientreport()
        {
            Console.WriteLine("ENTER THE DOCTOR ID UNDER WHOM YOU WANT TO FIND PATIENTS");
            var DOCID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE PATIENT ID YOU WANT TO FIND OUT ABOUT");
            var patientID = Convert.ToInt32(Console.ReadLine());
            List<Patient> patientList = context.Patients.FromSqlRaw<Patient>($"SELECT * FROM PATIENT WHERE DoctorID = {DOCID}").ToList();
            foreach (var item in patientList)
            {
                if(item.PatientId== patientID)
                {
                    Console.WriteLine(item.PatientId+ "  "+ item.PatientName+ "   "+ item.Disease);

                }
            }
        }
        public void getprescription()
        {
            Console.WriteLine("ENTER THE PATIENT ID YOU WANT TOget the prescription of");
            var patientID = Convert.ToInt32(Console.ReadLine());
            var prescription = context.Prescriptions.Where(x => x.PatientId == patientID).ToList();
            foreach (var item in prescription)
            {
                Console.WriteLine(item.PatientId+ "  "+ item.DrugId+ "   "+ item.Morning+"  "+ item.AfterNoon+ "  "+ item.Night);
            }
        }
    }
}
