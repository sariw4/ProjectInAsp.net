using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Medical.Models
{
    public class MedicineViewModel
    {
        public Medicine Current;

        [DisplayName("Commercial Name")]
        public string CommercialName
        {
            get { return Current.CommercialName; }
            set { Current.CommercialName = value; } 
        }
        [DisplayName("Generic Name")]
        public string GenericName
        {
            get { return Current.GenericName; }
            set { Current.GenericName = value; }
        }
        [DisplayName("Dose Characteristic")]
        public string DoseCharacteristic
        {
            get { return Current.DoseCharacteristic; }
            set { Current.DoseCharacteristic = value; }
        }
        [DisplayName("Active Ingredients")]
        public string ActiveIngredients
        {
            get { return Current.ActiveIngredients; }
            set { Current.ActiveIngredients = value; }
        }
        [DisplayName("Producer")]
        public string Producer
        {
            get { return Current.Producer; }
            set { Current.Producer = value; }
        }
        [DisplayName("Image")]
        public string ImageUrl
        {
            get { return Current.ImageUrl; }
            set { Current.ImageUrl = value; }
        }
        public int Id
        {
            get { return Current.Id; }
            set { Current.Id = value; }
        }

        public MedicineViewModel(Medicine medicine)
        {
            this.Current = medicine;
        }

    }
}