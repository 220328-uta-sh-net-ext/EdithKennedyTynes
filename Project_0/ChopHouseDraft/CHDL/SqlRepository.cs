using CHModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;


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

        public ChopHouse AddRestaurant(ChopHouse rest)
        /// <summary>
        /// "Restaurant added"
        /// </summary>
        /// <param name="rest"></param>
        /// <returns>the added restaurant <returns
        {
            string selectCommandString = "INSERT INTO ChopHouse(StoreID,Name,City,State) VALUES" +
                "(@storeid,@name,@city,@state)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            command.Parameters.AddWithValue("@storeid", rest.StoreID);
            command.Parameters.AddWithValue("@name", rest.Name);
            command.Parameters.AddWithValue("@city", rest.City);
            command.Parameters.AddWithValue("@state", rest.State);



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
        public List<ChopHouse> SearchRestaurants(string name, string s)
        {
            string selectCommandString = $"SELECT * FROM ChopHouse WHERE {name} = '{s}';";
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
                    StoreID = reader.GetString(0),
                    Name = reader.GetString(0),
                    City = reader.GetString(0),
                    State = reader.GetString(0),
                    /*Rating = (int)row[3],
                    Review = (string)row[4],
                    NumRatings = (int)row[5],*/

                });
                
            }
            return Restaurants;

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

    }

}



       

            

        
