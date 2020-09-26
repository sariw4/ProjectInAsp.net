using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medical.Models
{
    public class DoctorsModel
    {
        DoctorsLogic bl = new DoctorsLogic();

        public DoctorsModel()
        {

        }
        public IEnumerable<Doctor> GetDoctors()
        {
            return bl.GetDoctors();
        }
        public void AddD(string name, string phone, string email, string LicenceNumber, string Expertist)
        {
            Doctor doctor = new Doctor(name, phone, email, LicenceNumber, Expertist);
            bl.InsertDoctors(doctor);
        }
        public void Update(int id, string name, string phone, string email, string LicenceNumber, string Expertist)
        {
            Doctor doctor = new Doctor(name, phone, email, LicenceNumber, Expertist);
            bl.UpdateDoctors(doctor, id);
        }
        public void delete(int id)
        {
            bl.RemoveDoctors(id);

        }
    }
}