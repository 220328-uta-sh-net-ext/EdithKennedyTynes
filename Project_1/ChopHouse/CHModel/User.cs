using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHModel
{
    public class User
    {
        private string connectionString;

        public int ?UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }

        public User()
        {
            UserID = 0001;
            FirstName = "Edith";
            LastName = "KennedyTynes";
            UserName = "Code007";
            Password = "password123";
            Email = "code007@gmail.com";

        }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}\nLastName: {LastName}\nUserName: {UserName}\npassword: {Password}\nEmail: {Email}";
        }
    }
}
