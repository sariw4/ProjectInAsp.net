using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Medicine
    {
        public int Id { get; set; }

        [DisplayName("Commercial Name")]
        public string CommercialName { get; set; }

        [DisplayName("Generic Name")]
        public string GenericName { get; set; }
        public string Producer { get; set; }

        [DisplayName("Active Ingredients")]
        public string ActiveIngredients { get; set; }

        [DisplayName("Dose Characteristic")]
        public string DoseCharacteristic { get; set; }

        [DisplayName("Image")]
        public string ImageUrl { get; set; }
        //public DateTime BeginT { get; set; }
        //public DateTime EndT { get; set; }
        
        public string NDC { get; set; }
        public string ToString()
        {
            return CommercialName + " " + GenericName + " " + Producer + " " + ActiveIngredients + " " + DoseCharacteristic + " " + NDC + " ";
        }
        public Medicine(string commercialName, string genericName, string producer, string activeIngredients, string doseCharacteristic, string imageUrl, string ndc)
        {
            CommercialName = commercialName;
            GenericName = genericName;
            Producer = producer;
            ActiveIngredients = activeIngredients;
            DoseCharacteristic = doseCharacteristic;
            ImageUrl = imageUrl;
            NDC = ndc;
        }
        public Medicine()
        {

        }
    }
}

