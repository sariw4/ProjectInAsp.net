using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Medical.Models
{
    public class DoctorViewModel
    {
        public Doctor Current;

        [DisplayName("Name")]
        public string Name
        {
            get { return Current.Name; }
            set { Current.Name = value; }
        }
        [DisplayName("Phone Number")]
        public string Phone
        {
            get { return Current.Phone; }
            set { Current.Phone = value; }
        }
        [DisplayName("Expertist")]
        public string Expertist
        {
            get { return Current.Expertist; }
            set { Current.Expertist = value; }
        }
        [DisplayName("Licence Number ")]
        public string LicenceNumber
        {
            get { return Current.LicenceNumber; }
            set { Current.LicenceNumber = value; }
        }
        [DisplayName("Email")]
        public string Email
        {
            get { return Current.Email; }
            set { Current.Email = value; }
        }
        //[DisplayName("Image")]
        //public string ImageUrl
        //{
           // get { return Current.ImageUrl; }
            //set { Current.ImageUrl = value; }
        //}
        public int Id
        {
            get { return Current.Id; }
            set { Current.Id = value; }
        }

        public DoctorViewModel(Doctor doctor)
        {
            this.Current = doctor;
        }
    }
}