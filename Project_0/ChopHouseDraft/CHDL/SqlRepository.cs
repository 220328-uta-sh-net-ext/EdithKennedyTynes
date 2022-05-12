using CHModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using MySqlX.XDevAPI.Common;

namespace CHDL
{
    //sql repo is to connect to the database and coordinate data/tables to maniuplate and update the data connected to the
    //user input through the methods in the Repo 
    public class SqlRepository : IRepository
    {
        public const string connectionStringFilePath = "C:/Revature/Project_0/ChopHouseDraft/CHDL/Connection-string.txt";
        readonly string connectionString;
        public SqlRepository(string connectionString) //initalizing the connection string variable on  line 14 and file path on Line 13 
        {
             connectionString = File.ReadAllText(connectionStringFilePath); //assigning the connection string file path and reading the text.
             this.connectionString = connectionString;
        }



        public List<ChopHouse> GetRestaurants(string name, string s)
        {
            string selectCommandString = "SELECT * FROM ChopHouse ;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var Restaurants = new List<ChopHouse>();
            while (reader.Read())
            {
                Restaurants.Add(new ChopHouse
                {
                    Name = reader.GetString(0),
                    City = reader.GetString(1),

                    State = reader.GetString(2),
                    /*Rating = reader.GetInt32(3),

                    Review = reader.GetString(4),
                    NumRatings = reader.GetInt32(5),*/
                    StoreID = reader.GetString(6),

                });
            }
            return Restaurants;
        }
        public ChopHouse AddRestaurant(ChopHouse rest)
        /// <summary>
        /// "Restaurant added"
        /// </summary>
        /// <param name="rest"></param>
        /// <returns>the added restaurant <returns
        {
            string selectCommandString = "INSERT INTO ChopHouse(Name,City,State,StoreID) VALUES" +
               "(@name,@city,@state,@storeid)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            command.Parameters.AddWithValue("@name", rest.Name);
            command.Parameters.AddWithValue("@city", rest.City);
            command.Parameters.AddWithValue("state", rest.State);
            command.Parameters.AddWithValue("@storeid", rest.StoreID);


            connection.Open();
            command.ExecuteNonQuery();
            

            return rest;

            

        }
        public void AddReview(string StoreIDs, int reviewToAdd)
        {
            throw new NotImplementedException();
        }
        public ChopHouse SearchRestaurants(ChopHouse search)
        {
            string commandString = "SELECT * FROM ChopHouse";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {
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
            return search;

            var restaurants = new List<ChopHouse>();
            DataColumn levelColumn = dataSet.Tables[0].Columns[2];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                restaurants.Add(new ChopHouse
                {
                    Name = (string)row [0],
                    City = (string)row[1],
                    State = (string)row[2],
                    Rating = (int)row[3],
                    Review = (string)row[4],
                    NumRatings = (int)row[5],
                    StoreID = (string)row[6]

                }); 

            }
            return search;
        }

        public List<ChopHouse> DisplayAll(string r, string seeAll)
        {
            string selectCommandString = $"SELECT * FROM ChopHouse WHERE {r} = '{seeAll}';";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var Restaurants = new List<ChopHouse>();
            while (reader.Read())
            {
                Restaurants.Add(new ChopHouse
                {
                    Name = reader.GetString(0),
                    City = reader.GetString(1),

                    State = reader.GetString(2),
                    StoreID = reader.GetString(6),
                });
            }
            return Restaurants;
        }

        public List<ChopHouse> DisplayAll(ChopHouse play)
        {
            throw new NotImplementedException();
        }

        public List<ChopHouse>? DisplayAll()
        {
            throw new NotImplementedException();
        }

        public List<ChopHouse> GetRestaurants()
        {
            throw new NotImplementedException();
        }
    }   
}
