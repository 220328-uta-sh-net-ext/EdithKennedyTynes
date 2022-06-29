using CHModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Claims;

namespace CHDL
{


    public class UserRepository : IRepositoryUser//needs to connect to business logic 
    {
        //public const string connectionStringFilePath = "C:/Revature/P1/ChopHouse/CHDL/connection-string.txt";
        readonly string connectionString;

        public UserRepository(string connectionString)
        {
            //connectionString = File.ReadAllText(connectionStringFilePath); //assigning the connection string file path and reading the text.
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
                    StoreID = (int)row[0],
                    Name = (string)row[1],
                    City = (string)row[2],
                    State = (string)row[3],
                    Zip = (int)row[4],

                });
            }
            return chophouse;
        }


        public async Task<List<User>> GetAllUserAsync()
        {
            string commandString = $"SELECT * FROM User;";
            //string selectCommandString = $"SELECT * FROM ChopHouse WHERE  = '{All}';";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {

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
            var user = new List<User>();
            DataColumn levelColumn = dataSet.Tables[0].Columns[2];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                user.Add(new User
                {
                    UserID = (int)row[0],
                    FirstName = (string)row[1],
                    LastName = (string)row[2],
                    UserName = (string)row[3],
                    Password = (string)row[4],
                    Email = (string)row[5]
                });
            }
            return user;
        }

        public List<User> GetAllUser()
        {

            string commandString = $"SELECT * FROM User;";
            //string selectCommandString = $"SELECT * FROM ChopHouse WHERE  = '{All}';";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {
                /* async/await or */
                connection.Open();
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
            var user = new List<User>();
            DataColumn levelColumn = dataSet.Tables[0].Columns[2];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                user.Add(new User
                {
                    UserID = (int)row[0],
                    FirstName = (string)row[1],
                    LastName = (string)row[2],
                    UserName = (string)row[3],
                    Password = (string)row[4],
                    Email = (string)row[5]
                });
            }
            return user;


        }

        public async Task<List<HouseReview>> GetAllHouseReviewAsync()
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
            var housereview = new List<HouseReview>();
            DataColumn levelColumn = dataSet.Tables[0].Columns[2];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                housereview.Add(new HouseReview
                {
                    StoreID = (int)row[0],
                    UserId = (int)row[1],
                    Rating = (decimal)row[2],
                    Feedback = (string)row[3],

                });
            }
            return housereview;
        }
        public List<HouseReview> GetAllHouseReview()
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
                connection.Open();
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
            var review = new List<HouseReview>();
            DataColumn levelColumn = dataSet.Tables[0].Columns[2];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                review.Add(new HouseReview
                {
                    StoreID = (int)row[0],
                    UserId = (int)row[1],
                    Rating = (decimal)row[2],
                    Feedback = (string)row[3],

                });
            }
            return review;

        }

    }
}
