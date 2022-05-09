using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHModel
{
        public interface IUser 
        {
            static User NewUser = new User();


            bool Login(string username, string password);
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
