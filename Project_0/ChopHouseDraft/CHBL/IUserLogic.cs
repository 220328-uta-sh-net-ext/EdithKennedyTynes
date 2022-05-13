using CHDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHModel;



namespace CHBL
{
    public interface IUser 
    {
        public User CreateUser(User Create);


        bool Login(string username, string password);
        bool Register(string username, string password);

        interface Ilog
        {
            void LogError(string error);

        }
        interface IEmail
        {
            bool SendEmail(string emailContent);
        }

    }
    public interface IUserLogic 
    {
        User CreateUser(User Create);
        //List<User> SearchAll();
        void Add(CHDL.Admin admin);
        void Delete(CHDL.Admin admin);
        CHDL.Admin Update(CHDL.Admin admin);
    }

}




