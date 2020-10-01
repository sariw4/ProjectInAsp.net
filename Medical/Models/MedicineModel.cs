using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using BE;
using BL;

namespace Medical.Models
{
    public class MedicineModel
    {
        DrugAdminLogic bl = new DrugAdminLogic();
        PrescriptionsLogic bl1 =new PrescriptionsLogic();

        public MedicineModel()
        {

        }
        public IEnumerable<Medicine> GetMedicines()
        {
            return bl.GetMedicines();
        }
        public void Update(int id, string CommercialName, string GenericName, string Producer, string ActiveIngredients, string DoseCharacteristic, string image, string ndc)
        {
            Medicine medicine = new Medicine(CommercialName, GenericName, Producer, ActiveIngredients, DoseCharacteristic, image, ndc);
            bl.UpdateDrugs(medicine, id);
        }
        public void Add(string CommercialName, string GenericName, string Producer, string ActiveIngredients, string DoseCharacteristic, string image, string ndc)
        {
            Medicine medicine = new Medicine(CommercialName, GenericName, Producer, ActiveIngredients, DoseCharacteristic, @"/images/" + image, ndc);
            bl.AddDrugs(medicine);
        }

        public void delete(int id)
        {
            bl.RemoveDrugs(id);
        }
        public List<string> GetMedicineChart(int id)
        {
            int Count = 0;
            List<string>CountList=new List<string>();
            IEnumerable<Prescription> Prescriptions = bl1.GetPrescriptionsById(id);
            for (int i = 1; i < 7; i++)
            {
                foreach (var prescription in Prescriptions)
                {
                    if (prescription.BeginTime.Month == i)
                    {
                        Count++;
                    }
                }
                CountList.Add("Count");
            }
            return CountList;
        }
    }
}