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
        public string CommercialName { get; set; }
        public string GenericName { get; set; }
        public string Producer { get; set; }
        public string ActiveIngredients { get; set; }
        public string DoseCharacteristic { get; set; }
        public string ImageUrl { get; set; }
        //public DateTime BeginT { get; set; }
        //public DateTime EndT { get; set; }
        public string ToString()
        {
            return CommercialName + " "+ GenericName+ " " + Producer+" "+ ActiveIngredients+ " "+ DoseCharacteristic+ " ";
        }
    }
}
