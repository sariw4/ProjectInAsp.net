using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Admin:User
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }


        public Admin()
        {

        }
        public Admin(string username ,string password,string name, string phone, string mail)
        {
            UserName = username;
            Password = password;
            Name = name;
            Phone = phone;
            Mail = mail;
        }
        public Admin(Admin A)
        {
            UserName = A.UserName;
            Password = A.Password;
            Name = A.Name;
            Phone = A.Phone;
            Mail = A.Mail;
        }

    }
    
}
