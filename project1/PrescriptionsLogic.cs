using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public class PrescriptionsLogic
    {

        DAL.Prescriptions dal = new DAL.Prescriptions();
        DAL.Drugs DrugsDal = new DAL.Drugs();
        public void InsertPrescription(Prescription p)
        {
            dal.InsertPrescription(p);
        }
        public IEnumerable<Prescription> GetPrescriptions()
        {
            return dal.GetPrescriptions();
        }
        public IEnumerable<Prescription> GetPrescriptionsById(int id)
        {
            return dal.GetPrescriptionsById(id);
        }
        //למה ב bl
        public IEnumerable<string> GetNDCById(string id)
        {
            int Id = int.Parse(id);
            IEnumerable<Prescription> prescriptions= dal.GetPrescriptionsById(Id);
            List<string> NDC = new List<string>();
            foreach(var item in prescriptions)
            {
                if(item.PatientId==Id)
                {
                    NDC.Add(item.Ndc);
                }
            }
            return NDC;

        }
        public IEnumerable<Prescription> GetPrescriptionsByNameMed(string med)
        {
            return dal.GetPrescriptionsByNameMed(med);
        }

    }
}
