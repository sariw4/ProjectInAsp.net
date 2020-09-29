using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
  public  class User
    {            
        public int Id { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        public User() { }
        public User(string userName, string password) 
        {
            UserName = userName;
            Password = password;
        }
        public User(User U)
        {
            UserName = U.UserName;
            Password = U.Password;
        }
    }
    
}
