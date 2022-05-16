using CHModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CHDL
{
   
    public class UserRepository : IRepositoryUser//needs to connect to business logic 
    {
        public const string connectionStringFilePath = "C:/Revature/Project_0/ChopHouseDraft/CHDL/Connection-string.txt";
        readonly string connectionString;

        public UserRepository(string connectionString)
        {
            connectionString = File.ReadAllText(connectionStringFilePath); //assigning the connection string file path and reading the text.
            this.connectionString = connectionString;
        }

        public User CreateUser(User Create) 
        {
            string selectCommandString = "INSERT INTO User(UserID,FirstName,LastName,UserName,Password,Email) VALUES" +
                "(@@userid,@firstname,@lastname,@username,@password,@email)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            command.Parameters.AddWithValue("@userid", Create.UserID);
            command.Parameters.AddWithValue("@firstname", Create.FirstName);
            command.Parameters.AddWithValue("@lastname", Create.LastName);
            command.Parameters.AddWithValue("@username", Create.UserName);
            command.Parameters.AddWithValue("@password", Create.Password);
            command.Parameters.AddWithValue("@email", Create.Email);


            connection.Open();
            command.ExecuteNonQuery();


            return Create;
        }

        public bool Login(User login)// how to save to db? Login for user and admin 
        {
            throw new NotImplementedException();
        }

        public async Task<List<ChopHouse>> GetAllChopHouseAsync()
        {
            string commandString = $"SELECT * FROM ChopHouse;";
            //string selectCommandString = $"SELECT * FROM ChopHouse WHERE  = '{All}';";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {
                /* async or */
                await connection.OpenAsync();
                adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.}
            }
            catch (SqlException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            var chophouse = new List<ChopHouse>();
            DataColumn levelColumn = dataSet.Tables[0].Columns[2];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                chophouse.Add(new ChopHouse
                {
                    StoreID = (string)row[0],
                    Name = (string)row[1],
                    City = (string)row[2],
                    State = (string)row[3],

                });
            }
            return chophouse;
        }

        public void Save(User Create)
        {
            throw new NotImplementedException();
        }

        public void Save(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
    
}
