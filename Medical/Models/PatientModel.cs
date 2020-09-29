using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medical.Models
{
    public class PatientModel
    {
        PatientsLogic bl = new PatientsLogic();
        public PatientModel()
        {

        }
        public IEnumerable<Patient> GetPatients()
        {
            return bl.GetPatients();

        }
        public void Update(int id, string firstname, string lastname,string date, string phone, string email)
        {
            List<Medicine> drugs = new List<Medicine>();
            DateTime d = Convert.ToDateTime(date);
            Patient patient = new Patient(firstname, lastname, d, phone, email, drugs);
            bl.UpdatePatients(patient, id);
        }
        public void Add(string firstname, string lastname, string date, string phone, string email)
        {
            List<Medicine> Drugs = new List<Medicine>();
            DateTime d = Convert.ToDateTime(date);
            Patient patient = new Patient(firstname, lastname, d, phone, email, Drugs);
            bl.InsertPatients(patient);
        }

        public void delete(int id)
        {
            bl.Removepatients(id);

        }

    }
}