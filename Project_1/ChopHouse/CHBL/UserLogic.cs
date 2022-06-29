using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHDL;
using CHModel;

namespace CHBL
{
    public class UserLogic : IUserLogic
    {
        readonly IRepositoryUser UserRepo;
        readonly IUserLogic userLogic;

        public UserLogic(IRepositoryUser repo)//injecting dependency through user repo
        {
            this.UserRepo = repo;
        }
        
        /*public void Save(User Create)
        {
            UserRepo.Save(Create);
        }  */

        /*public abstract void Add(CHDL.Admin admin);
       //Add Admin~> Abstract method with only method declaration, no implementation
        public abstract void Delete(CHDL.Admin admin);
        public abstract CHDL.Admin SearchUser(string ID);
        public abstract CHDL.Admin Update(CHDL.Admin admin);
        public User CreateUser(User Create)
        {
            throw new NotImplementedException();
        }
*/
        public bool Login(User login)
        {
            return UserRepo.Login(login);
        }

        public User CreateUser(User Create)
        {
            return UserRepo.CreateUser(Create);
        }

        public User Add(Admin admin)
        {
            throw new NotImplementedException();
        }

        public User Delete(Admin admin)
        {
            throw new NotImplementedException();
        }

        public Admin Update(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}
