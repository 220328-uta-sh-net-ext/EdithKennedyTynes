using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHBL;
using CHDL;
using CHModel;
using ChopHouseDraftUI;

namespace ChopHouseDraftUI
{
    public class RegUser : User, IUserLogic
    {
        public static RegUser newRegUser = new RegUser();

        readonly IChopHouseLogic logic;
        bool Register(string username, string password)
        {
            throw new NotImplementedException();
        }
        public User CreateUser(User Create)
        {
            throw new NotImplementedException();
        }

        public List<User> SearchAll()
        {
            throw new NotImplementedException();
        }


        /*
        public void Display()
        {
            Console.WriteLine("Enter Restaurant Information");
            Console.WriteLine("<0> Go Back to MainMenu");
            Console.WriteLine("<1> FirstName - " + User.FirstName);
            Console.WriteLine("<2> City - " + User.LastName);
            Console.WriteLine("<3> State - " + User.UserName);
            Console.WriteLine("<4> Rating - " + User.Password);
            Console.WriteLine("<5> Review - " + User.email);
            Console.WriteLine("<8> Save Restaurant");

        }*/
    }
}
