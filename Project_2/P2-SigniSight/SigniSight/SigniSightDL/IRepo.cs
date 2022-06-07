using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SigniSightModel;

namespace SigniSightDL
{
    public interface IRepo
    {
        User AddUser(User userToAdd);

        List<User> GetAllUsers();
    }
}
