using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHDL;


namespace CHBL
{
    public abstract class UserOperations 
    {
        public abstract void Add(CHDL.Admin admin); //Add Admin~> Abstract method with only method declaration, no implementation
        public abstract void Delete(CHDL.Admin admin);

        public abstract CHDL.Admin SearchUser(string ID);

        public abstract CHDL.Admin Update(CHDL.Admin admin);
    }

    public class UserImplementations : IUserOperations
    {
        public void Add(CHDL.Admin admin) //add
        {
            throw new NotImplementedException();
        }
        public void Delete(CHDL.Admin admin) //remove
        {
            throw new NotImplementedException();
        }
        public CHDL.Admin SearchUser(string ID) //search
        {
            throw new NotImplementedException();
        }
        public CHDL.Admin Update(CHDL.Admin Admin) //modify
        {
            throw new NotImplementedException();
        }
    }
}
