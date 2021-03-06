using CHModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System;
using CHDL;


namespace CHDL
{
    
    
    public class SqlRepository : IRepository
    {
        //public const string connectionStringFilePath = "C:/Revature/P1/ChopHouse/CHDL/connection-string.txt";
        readonly string connectionString;

        public SqlRepository(string connectionString) //initalizing the connection string variable on  line 14 and file path on Line 13 
        {
            //connectionString = File.ReadAllText(connectionStringFilePath); //assigning the connection string file path and reading the text.
            this.connectionString = connectionString;
        }

        public ChopHouse AddRestaurant(ChopHouse rest)
        /// <summary>
        /// "Restaurant added"
        /// </summary>
        /// <param name="rest"></param>
        /// <returns>the added restaurant <returns
        {
            string commandString = "INSERT INTO ChopHouse(StoreID,Name,City,State,Zip) " + 
                "VALUES (@storeid, @name, @city, @state, @zip);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@storeid", rest.StoreID);
            command.Parameters.AddWithValue("@name", rest.Name);
            command.Parameters.AddWithValue("@city", rest.City);
            command.Parameters.AddWithValue("@state", rest.State);
            command.Parameters.AddWithValue("@zip", rest.Zip);
            connection.Open();
            command.ExecuteNonQuery();
            return rest;
        }
        public HouseReview AddHouseReview(HouseReview view)
        {
            string selectCommandString = "INSERT INTO HouseReview(StoreID,UserId,Rating,Feedback) VALUES" +
                "(@storeid,@userid,@rating,@feedback)";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            command.Parameters.AddWithValue("@storeid", view.StoreID);
            command.Parameters.AddWithValue("@userid", view.UserId);
            command.Parameters.AddWithValue("@rating", view.Rating);
            command.Parameters.AddWithValue("@feedback", view.Feedback);
            connection.Open();
            command.ExecuteNonQuery();
            return view;
        }


        public List<ChopHouse> SearchRestaurants()
        {
            string selectCommandString = "SELECT * FROM ChopHouse;";
            //string selectCommandString = $"SELECT * FROM ChopHouse WHERE {name} = '{s}';";
            //string commandString = "SELECT * FROM ChopHouse";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(selectCommandString, connection);


            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            //IDataAdapter adapter = new SqlDataAdapter(command);
            var Restaurants = new List<ChopHouse>();
            while (reader.Read())
            {
                Restaurants.Add(new ChopHouse
                {
                    StoreID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    City = reader.GetString(2),
                    State = reader.GetString(3),
                    Zip = reader.GetInt32(4),
                    /*Rating = (int)row[3],
                    Review = (string)row[4],
                    NumRatings = (int)row[5],*/

                });

            }
            return Restaurants;

        }
        /*public async Task<List<ChopHouse>> GetAllChopHouseConnected() // GetAllConnected() method Async.. and return task of list of ChopHouse Restaurants
        {
            string commandString = "SELECT * FROM ChopHouse;";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(commandString, connection);
            await connection.OpenAsync();//Async
            using SqlDataReader reader = await command.ExecuteReaderAsync();//Async w/ await
            var chophouse = new List<ChopHouse>();
            while (await reader.ReadAsync())//Async w/ await keyword
            {
                //put all constructors for ChopHouse and Users
                chophouse.Add(new ChopHouse
                {
                    StoreID = reader.GetString(0),
                    Name = reader.GetString(1),
                    City = reader.GetString(2),
                    State = reader.GetString(3),
                    Zip = reader.GetInt32(4),

                });
            }
            return chophouse;
        }                   */

        public List<ChopHouse> GetAllChopHouses()
        {
            //var seeAll = DisplayAll();

            string commandString = $"SELECT * FROM ChopHouse;";
            //string selectCommandString = $"SELECT * FROM ChopHouse WHERE  = '{All}';";

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
                throw; //rethrow the exeption
            }
            catch (Exception ex)
            {

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
                    Zip = (int)row[4]

                });
            }
            return chophouse;
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
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            var review= new List<HouseReview>();
            DataColumn levelColumn = dataSet.Tables[0].Columns[2];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                /*decimal rating = 0.0M;
                int counter = 0;*/
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

    
    



    
             
