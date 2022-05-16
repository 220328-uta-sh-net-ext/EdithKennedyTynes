using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHDL;
using CHModel;

namespace CHBL
{
    public abstract class UserLogic : IUserLogic 
    {
        readonly IRepositoryUser UserRepo;

        public UserLogic(IRepositoryUser userRepo)//injecting dependency through user repo
        {
            this.UserRepo = userRepo;
        }
        public abstract void Add(CHDL.Admin admin);
       //Add Admin~> Abstract method with only method declaration, no implementation
        public abstract void Delete(CHDL.Admin admin);

        public abstract CHDL.Admin SearchUser(string ID);

        public abstract CHDL.Admin Update(CHDL.Admin admin);
        public User CreateUser(User Create)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }

    public class UserImplementations : IUserLogic // ALL abstract methods and must be cast?
    {
        public void Add(CHDL.Admin admin) //add
        {
            throw new NotImplementedException();
        }

        public User CreateUser(User Create) //Admin and User ability
        {
            throw new NotImplementedException();
        }

        public void Delete(CHDL.Admin admin) //remove for AdminUser responsibility but User should be able to make a request to delete account
        {
            throw new NotImplementedException();
        }

        public CHDL.Admin SearchUser(string ID) //search for AdminUser
        {
            throw new NotImplementedException();
        }
        public CHDL.Admin Update(CHDL.Admin Admin) //modify for AdminUser
        {
            throw new NotImplementedException();
        }
    }
}
