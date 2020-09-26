using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DisplayName("Phone Number")]

        public string Phone { get; set; }

        [DisplayName("Licence Number ")]

        public string LicenceNumber { get; set; }

        public string Expertist { get; set; }

        public string Email { get; set; }

        public Doctor(string name, string phone, string licenceNumber, string expertist, string email)
        {
            Name = name;
            Phone = phone;
            LicenceNumber = licenceNumber;
            Expertist = expertist;
            Email = email;

        }
        public Doctor()
        {

        }

    }
}

