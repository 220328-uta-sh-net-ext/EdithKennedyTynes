using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHModel;
namespace CHBL
{
    public class UserOperations : User// ALL abstract methods and must be cast?
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

