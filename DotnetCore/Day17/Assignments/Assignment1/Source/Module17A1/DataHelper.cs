using Microsoft.EntityFrameworkCore;
using Module17A1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module17A1
{
    public class DataHelper
    {
        public HospitalContext context { get; set; }
        public DataHelper()
        {
            context = new HospitalContext();
        }


        public async Task<List<Doctor>> GetDoctor()
        {
            var doc = await (from d in context.Doctors
                             select d).ToListAsync();
            return doc;
        }
        public async Task<Doctor> GetDoctorByID(int id)
        {
            var doc = await (from d in context.Doctors
                             where d.DoctorId==id
                             select d).SingleAsync();
            return doc;
        }
        public async Task<Doctor> AddDoctor(Doctor doctor)
        {
            context.Add(doctor);
            await context.SaveChangesAsync();
            return doctor;
        }

        public async Task<Doctor> UpdateDoctor(int id, Doctor doctor)
        {
            var doc = await context.Doctors.Where(x => x.DoctorId == id).FirstAsync();

            doc.DoctorName = doctor.DoctorName;
            doc.Speciality = doctor.Speciality;
            context.Update(doc);
            await context.SaveChangesAsync();

            return doc;
        }
        public async Task<string> DeleteDoctor(int id)
        {
            var doc = await context.Doctors.Where(x => x.DoctorId == id).FirstAsync();
            context.Remove(doc);
            await context.SaveChangesAsync();
            return "DOCTOR DELETED";
        }
    }
}
