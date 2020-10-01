using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Drugs
    {
        public void InsertDrugs(Medicine m)
        {
            try
            {
                using (var ctx = new mediDB())
                {
                    ctx.Drugs.Add(m);
                    ctx.SaveChanges();
                }
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }

        public void RemoveDrugs(int id)
        {
            try
            {
                using (var ctx = new mediDB())
                {
                    Medicine medicine = ctx.Drugs.Find(id);
                    ctx.Drugs.Remove(medicine);
                    ctx.SaveChanges();
                }
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }

        public void UpdateDrugs(Medicine medicine, int id)
        {

            try
            {
                using (var ctx = new mediDB())
                {
                    Medicine tmp = ctx.Drugs.First(m=>m.Id==id);
                    tmp.CommercialName = medicine.CommercialName;
                    tmp.GenericName = medicine.GenericName;
                    tmp.Producer = medicine.Producer;
                    tmp.ActiveIngredients = medicine.ActiveIngredients;
                    tmp.DoseCharacteristic = medicine.DoseCharacteristic;
                    tmp.ImageUrl = medicine.ImageUrl;
                    ctx.SaveChanges();
                }
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
        public IEnumerable<Medicine> GetMedicines()
        {
            try
            {
                List<Medicine> result = new List<Medicine>();
                result.Add(new Medicine("y", "u", "o", "g", "o", @"/images/Advil.jpg", "150-185"));
                using (var ctx = new mediDB())
                {
                    foreach (var drug in ctx.Drugs)
                    {
                        result.Add(drug);
                    }
                }
                return result;
            }
            catch (Exception e) { throw new Exception(e.Message); }
        }
    }
}
