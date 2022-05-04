using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopHouseModel
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }

        public User()
        {
            FirstName = "Edith";
            LastName = "KennedyTynes";
            UserName = "Code007";
            Password = "password123";
            Email = "code007@gmail.com";

        }
        public override string ToString()
        {
            return $"FirstName: {FirstName}\nLastName: {LastName}\nUserName: {UserName}\npassword: {Password}\nEmail: {Email}";
        }

    }
        
    
} 

