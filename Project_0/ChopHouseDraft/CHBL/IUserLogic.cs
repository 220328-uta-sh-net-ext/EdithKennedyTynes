﻿using CHDL;
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


        /// <summary>
        /// Onlu AdminUser should have access to these properties and methods not the User
        /// </summary>
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
        void Add(CHDL.Admin admin); //AdminUser; Abstract methods maybe consider using Delegate?
        void Delete(CHDL.Admin admin); //AdminUser
        CHDL.Admin Update(CHDL.Admin admin); //AdminUser
    }

}




