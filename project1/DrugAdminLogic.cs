using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class DrugAdminLogic
    {
        public bool AddDrug(int id, string commercialName, string genericName, string producer,
                                     string activeIngredients,string doseCharacteristic, string imageUrl)
        {
            bool result = true;
            //Add your buesiness logic here
            DAL.ReadWriteDrugs dal = new DAL.ReadWriteDrugs();
            dal.InsertDrugs(id, commercialName, genericName, producer,activeIngredients,doseCharacteristic, imageUrl);
            return result;
        }

        public bool RemoveDrugs(int id, string commercialName, string genericName, string producer,
                                     string activeIngredients, string doseCharacteristic, string imageUrl)
        {
            bool result = true;
            //Add your buesiness logic here
            DAL.ReadWriteDrugs dal = new DAL.ReadWriteDrugs();
            dal.RemoveDrugs(id, commercialName, genericName, producer, activeIngredients, doseCharacteristic, imageUrl);
            return result;
        }

    }
}