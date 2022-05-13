using CHModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CHDL
{
   
    public class UserRepository : IRepositoryUser//needs to connect to business logic 
    {
        public const string connectionStringFilePath = "C:/Revature/Project_0/ChopHouseDraft/CHDL/Connection-string.txt";
        readonly string connectionString;

        public UserRepository( string connectionString)
        {
            connectionString = File.ReadAllText(connectionStringFilePath); //assigning the connection string file path and reading the text.
            this.connectionString = connectionString;
        }

        public User CreateUser(User Create)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool Register(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
