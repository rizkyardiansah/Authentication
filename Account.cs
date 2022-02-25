using System;
using System.Collections.Generic;
using System.Text;

namespace Authentication
{
    class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    
        public Account()
        {

        }
        public Account(string firstName, string lastName, string password, string userName)
        {
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            UserName = userName;
        }
    }

}
