using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    internal interface IUser
    {
        bool Login (string username, string password);
        bool Register(string username, string password);
    }
    interface Ilog
    {
        void LogError(string error);
       
    }
    interface IEmail
    {
        bool SendEmail(string emailContent);
    }
}
