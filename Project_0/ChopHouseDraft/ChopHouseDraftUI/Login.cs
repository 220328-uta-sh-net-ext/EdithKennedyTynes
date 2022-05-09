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
    public class Login : IUser
    {
        public bool Register(string username, string password)
        {
            throw new NotImplementedException();
        }

        bool IUser.Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
