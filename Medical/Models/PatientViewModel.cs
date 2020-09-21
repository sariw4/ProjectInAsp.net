using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Medical.Models
{
    public class PatientViewModel
    {
        public Patient Current;

        [DisplayName("Name")]
        public string Name
        {
            get { return Current.Name; }
            set { Current.Name = value; }
        }
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth
        {
            get { return Current.DateOfBirth; }
            set { Current.DateOfBirth = value; }
        }
        [DisplayName("Phone")]
        public string Phone
        {
            get { return Current.Phone; }
            set { Current.Phone = value; }
        }
        [DisplayName("Email")]
        public string Email
        {
            get { return Current.Email; }
            set { Current.Email = value; }
        }
        public int Id
        {
            get { return Current.Id; }
            set { Current.Id = value; }
        }

        public PatientViewModel(Patient patient)
        {
            this.Current = patient;
        }

    }
}
