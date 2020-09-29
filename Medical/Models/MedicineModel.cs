using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BE;
using BL;

namespace Medical.Models
{
    public class MedicineModel
    {
        DrugAdminLogic bl = new DrugAdminLogic();

        public MedicineModel()
        {

        }
        public IEnumerable<Medicine> GetMedicines()
        {
            return bl.GetMedicines();
        }
        public void Update(int id, string CommercialName, string GenericName, string Producer, string ActiveIngredients, string DoseCharacteristic, string image)
        {
            Medicine medicine = new Medicine(CommercialName, GenericName, Producer, ActiveIngredients, DoseCharacteristic, image);
            bl.UpdateDrugs(medicine, id);
        }
        public void Add(string CommercialName, string GenericName, string Producer, string ActiveIngredients, string DoseCharacteristic, string image)
        {
            Medicine medicine = new Medicine(CommercialName, GenericName, Producer, ActiveIngredients, DoseCharacteristic, @"/images/" + image);
            bl.AddDrugs(medicine);
        }

        public void delete(int id)
        {
            bl.RemoveDrugs(id);
        }
    }
}