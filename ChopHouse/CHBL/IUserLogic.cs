using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHModel;
using CHDL;

namespace CHBL
{
    public interface IUserLogic
    {
        public bool Login(User login)
        {
            Dictionary<string, string> UserRecords = new Dictionary<string, string>()
            {
            {"UserName1", "Password1" },
            {"UserName2", "Password2" },
            {"UserName3", "Password3" },
            {"UserName4", "Password4" },
            {"UserName5", "Password5" }
            };

            if (!UserRecords.Any(a => a.Key == login.UserName && a.Value == login.Password)) //Lambdas Expression
            {
                return false;
            }
            else
                return true;
        }

        public User CreateUser(User Create)
        {
            throw new NotImplementedException();
        }

        public void Add(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void Delete(Admin admin)
        {
            throw new NotImplementedException();
        }

        public Admin Update(Admin admin)
        {
            throw new NotImplementedException();
        }

    }
}
