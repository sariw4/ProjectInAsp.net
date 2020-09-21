using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medical.Models
{
    public class DoctorsModel
    {
        public List<Doctor> Doctors { get; set; }

        public DoctorsModel()
        {
            Doctors = new List<Doctor>
            {
                new Doctor{Id=11,Name="ari",Phone="0529215864",Expertist="m",
                LicenceNumber="1234",Email="g@gmail.com"},
                new Doctor{Id=12,Name="rafi",Phone="0529215864",Expertist="u",
                LicenceNumber="5436",Email="g@gmail.com"},

            };
        }
        public List<DoctorViewModel> GetDoctors()
        {
            List<DoctorViewModel> Result = new List<DoctorViewModel>();
            DoctorViewModel m = null;
            foreach (var item in Doctors)
            {
                m = new DoctorViewModel(item);
                Result.Add(m);
            }
            return Result;
        }
        public DoctorViewModel GetDoctor(int Id)
        {
            DoctorViewModel Result = null;
            var AllDoctors = GetDoctors();
            Result = (from s in AllDoctors
                      where s.Id == Id
                      select s).Single<DoctorViewModel>();
            return Result;
        }
        public void AddD(string name, string phone,string email, string LicenceNumber, string Expertist)
        {
            return;
        }
        public void Update(int id, string name, string phone, string email, string LicenceNumber, string Expertist)
        {
            var Medicine = GetDoctor(id);
        }
        public void delete(int id)
        {
            var Medicine = GetDoctor(id);

        }
    }
}