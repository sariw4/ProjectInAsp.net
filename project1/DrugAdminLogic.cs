using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DrugAdminLogic
    {
        DAL.Drugs dal = new DAL.Drugs();
        public void AddDrugs(Medicine m)
        {
            dal.InsertDrugs(m);
        }
        public void RemoveDrugs(int id)
        {
            dal.RemoveDrugs(id);
        }
        public void UpdateDrugs(Medicine medicine, int id)
        {
            dal.UpdateDrugs(medicine, id);
        }
        public IEnumerable<Medicine> GetMedicines()
        {
            return dal.GetMedicines();
        }

        //public bool AddDrug(int id, string commercialName, string genericName, string producer,
        //                             string activeIngredients,string doseCharacteristic, string imageUrl)
        //{
        //    bool result = true;
        //    //Add your buesiness logic here
        //    DAL.ReadWriteDrugs dal = new DAL.ReadWriteDrugs();
        //    dal.InsertDrugs(id, commercialName, genericName, producer,activeIngredients,doseCharacteristic, imageUrl);
        //    return result;
        //}

        //public bool RemoveDrugs(int id, string commercialName, string genericName, string producer,
        //                             string activeIngredients, string doseCharacteristic, string imageUrl)
        //{
        //    bool result = true;
        //    //Add your buesiness logic here
        //    DAL.ReadWriteDrugs dal = new DAL.ReadWriteDrugs();
        //    dal.RemoveDrugs(id, commercialName, genericName, producer, activeIngredients, doseCharacteristic, imageUrl);
        //    return result;
        //}

    }
}