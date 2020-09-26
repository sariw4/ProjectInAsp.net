using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Patient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public List<Medicine> Drugs { get; set; }

        public Patient(string name, DateTime date, string phone, string email, List<Medicine> drugs)
        {
            Name = name;
            DateOfBirth = date;
            Phone = phone;
            Email = email;
            Drugs = drugs;
        }
        public Patient()
        {
           
        }
    }

}

