using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
  public  class User
    {            
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public User() { }
        public User(string userName, string password, string firstName, string lastName) 
        {
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }
        public User(User U)
        {
            UserName = U.UserName;
            Password = U.Password;
            FirstName = U.FirstName;
            LastName = U.LastName;
        }
        public virtual string ReturnType() { return null; }

    }
    
}
