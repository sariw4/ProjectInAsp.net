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
        public IEnumerable<Prescription> GetPrescriptionsByIdMed(int id)
        {
            return dal.GetPrescriptionsByIdMed(id);
        }

    }
}
