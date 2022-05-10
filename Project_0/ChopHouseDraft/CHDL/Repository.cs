using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHModel;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Data;


//Repository is the method implementation connection with the IRepository for user input 
namespace CHDL
{
    public class Repository : IRepository
    {
        public const string connectionStringFilePath = "C:/Revature/Project_0/ChopHouseDraft/CHDL/Connection-string.txt";
        readonly string connectionString;

        public Repository()
        {
        }

        public Repository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        

        public ChopHouse AddRestaurant(ChopHouse Chop)
        {

            string selectCommandString = "INSERT INTO ChopHouse(Name,City,State,Rating,Review,NumRatings,StoreID) VALUES" +
                "(@name,@city,@state,@rating,@review,@numrating,@storeid)";


            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            command.Parameters.AddWithValue("@name", Chop.Name);
            command.Parameters.AddWithValue("@city", Chop.City);
            command.Parameters.AddWithValue("state", Chop.State);
            command.Parameters.AddWithValue("@rating", Chop.Rating);
            command.Parameters.AddWithValue("@review", Chop.Review);
            command.Parameters.AddWithValue("@numratings", Chop.NumRatings);
            command.Parameters.AddWithValue("@storeId", Chop.StoreID);
            connection.Open();
            command.ExecuteNonQuery();

            return Chop;
        }
        public void AddReview(string StoreIDs, int reviewToAdd)
        {
            string selectCommandString = $"UPDATE ChopHouse SET Review = Review + @rate,NumRatings = NumRatings + 1 WHERE StoreID = '{StoreIDs}'";
            using SqlConnection connection = new(selectCommandString);
            using SqlCommand command = new(selectCommandString, connection);
            command.Parameters.AddWithValue("@rate", reviewToAdd);
            connection.Open();
            command.ExecuteNonQuery();


        }

        public List<ChopHouse> DisplayAll(string r, string seeAll)
        {
            string selectCommandString = $"SELECT * FROM ChopHouse WHERE {r} = '{seeAll}';";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new SqlCommand(selectCommandString, connection);
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
                    Rating = reader.GetInt32(3),

                    Review = reader.GetString(4),
                    NumRatings = reader.GetInt32(5),
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
                string selectCommandString = "SELECT * FROM ChopHouse";

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
                        Rating = reader.GetInt32(3),

                        Review = reader.GetString(4),
                        NumRatings = reader.GetInt32(5),
                        StoreID = reader.GetString(6),

                    });
                }
                return Restaurants;

            }
    }
    public class UserRepo : IRepositoryUser
    {
        readonly string connectionString;

        public UserRepo(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public User CreateUser(User use)
        {
            string selectCommandString = "INSERT INTO UserAccount(FirstName,LastName,UserName,Password,Email,VALUES" +
                                            "(@lastname,@firstname,@username,@password,@email)";
            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            command.Parameters.AddWithValue("@firstname", use.FirstName);
            command.Parameters.AddWithValue("@lastname", use.LastName);
            command.Parameters.AddWithValue("@username", use.UserName);
            command.Parameters.AddWithValue("@password", use.Password);
            command.Parameters.AddWithValue("@email", use.Email);

            connection.Open();
            command.ExecuteNonQuery();

            return use;

        }

        public List<User> DisplayUsers()
        {
            string selectCommandString = "SELECT * FROM UserAccount";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(selectCommandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var Users = new List<User>();
            while (reader.Read())
            {
                Users.Add(new User
                {
                    FirstName = reader.GetString(0),
                    LastName = reader.GetString(1),

                    UserName = reader.GetString(2),
                    Password = reader.GetString(3),

                    Email = reader.GetString(4),

                });
            }
            return Users;
        }

    }

}

