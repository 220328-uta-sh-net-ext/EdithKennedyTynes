using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHDL
{
   
    public class UserRepository //needs to connect to business logic 
    {
        private const string connectionStringFilePath = "C:/Revature/Project_0/ChopHouseDraft/CHDL/Connection-string.txt";
        readonly string connectionString;

        public UserRepository( string connectionString)
        {
            this.connectionString = connectionString;
        }


    }
}
