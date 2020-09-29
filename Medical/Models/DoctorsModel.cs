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
        public void AddD(string firstname, string lastname, string phone, string email, string LicenceNumber, string Expertist)
        {
            string Password = Convert.ToString(new Random());
            Doctor doctor = new Doctor(lastname, Password, firstname, lastname, phone, email, LicenceNumber, Expertist);
            bl.InsertDoctors(doctor);
        }
        public void Update(int id, string firstname, string lastname, string phone, string email, string LicenceNumber, string Expertist)
        {

            Doctor doctor = new Doctor(null, null, firstname, lastname, phone, email, LicenceNumber, Expertist);
            bl.UpdateDoctors(doctor, id);
        }
        public void delete(int id)
        {
            bl.RemoveDoctors(id);

        }
        public User ReturnUser(string U,string P)
        {
            User user = new User(U, P);
            user = bl.ReturnUser(user);
            return user;
        }
    }
}