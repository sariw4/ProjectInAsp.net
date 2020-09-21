using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medical.Models
{
    public class PatientModel
    {
        
            public List<Patient> Patients { get; set; }

            public PatientModel()
            {
                Patients = new List<Patient>
                {
                  new Patient{Id=11,Name="Avi",DateOfBirth=new DateTime(2000,3,1),Phone="0539620601",Email="d@gmailcom"},
                  new Patient{Id=12,Name="Shalom",DateOfBirth=new DateTime(1978,4,11),Phone="0534720601",Email="g@gmailcom"}
                };
            }

            public List<PatientViewModel> GetPatients()
            {
                List<PatientViewModel> Result = new List<PatientViewModel>();
                PatientViewModel m = null;
                foreach (var item in Patients)
                {
                    m = new PatientViewModel(item);
                    Result.Add(m);
                }
                return Result;
            }
            public PatientViewModel GetPatient(int Id)
            {
                PatientViewModel Result = null;
                var AllPatients = GetPatients();
                Result = (from s in AllPatients
                          where s.Id == Id
                          select s).Single<PatientViewModel>();
                return Result;

            }

            public void Update(int id, string name, string date, string phone, string email)
            {
                var Medicine = GetPatient(id);



            }
            public void Add(string name, string date,string phone,string email)
            {
                return;
            }

            public void delete(int id)
            {
                var Medicine = GetPatient(id);

            }
        
    }
}