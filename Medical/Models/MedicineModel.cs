using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BE;

namespace Medical.Models
{
    public class MedicineModel
    {
        public List<Medicine> Medicines { get; set; }

        public MedicineModel()
        {
            Medicines = new List<Medicine>
            {
                new Medicine{Id=11,CommercialName="a",GenericName="a",ActiveIngredients="g" ,
                DoseCharacteristic="t",ImageUrl=@"/images/Nurofen.jpg",Producer="t"},
                new Medicine{Id=12,CommercialName="r",GenericName="ae",ActiveIngredients="ge" ,
                DoseCharacteristic="te",ImageUrl=@"/images/Advil.jpg",Producer="te"}

            };
        }
       
        public List<MedicineViewModel> GetMedicines()
        {
            List<MedicineViewModel> Result = new List<MedicineViewModel>();
            MedicineViewModel m = null;
            foreach (var item in Medicines)
            {
                m = new MedicineViewModel(item);
                Result.Add(m);
            }
            return Result;
        }
        public MedicineViewModel GetMedicine(int Id)
        {
            MedicineViewModel Result = null;
            var AllMedicines = GetMedicines();
            Result = (from s in AllMedicines
                      where s.Id == Id
                      select s).Single<MedicineViewModel>();
            return Result;

        }

        public void Update(int id, string Commerical, string Generic, string P)
        {
            var Medicine = GetMedicine(id);
            


        }
        public void Add(string m, string image)
        {
            return;
        }
        
        public void delete(int id)
        {
            var Medicine = GetMedicine(id);
            
        }
    }
}