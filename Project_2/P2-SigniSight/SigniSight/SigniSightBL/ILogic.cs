using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SigniSightModel;
using SigniSightDL;

namespace SigniSightBL
{
    public interface ILogic
    {
        List<User> GetUserAccount(string Username, string Password);

        bool Authenticate(User user);

    }
}
