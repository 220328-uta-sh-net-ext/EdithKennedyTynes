using System.Collections.Generic;
using System.IO;
using RestaurantModel;
using System.Text.Json;
using System;
namespace RestaurantDL
{
    public class Repository : IRepository
    {
        private string filePath = "../RestaurantDL/Database/";
        private string jsonString;
        public Restaurant AddRestaurant(Restaurant rest)//Serialization; converting objects to stream of bytes to store object
                                                        //or transmit into memory, database, or file
        {
            var Restaurants = GetAllRestaurants();
            Restaurants.Add(rest);
            var restaurantString = JsonSerializer.Serialize<List<Restaurant>>(Restaurants, new JsonSerializerOptions { WriteIndented = true });
            try
            {
                File.WriteAllText(filePath + "Restaurant.json", restaurantString);

            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Please check the path, " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check the file name, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return rest;
        }

        public Review AddReview(int StoreIDs, Review reviewToAdd)
        {
            var Reviews = reviewToAdd();
            Reviews.Add(reviewToAdd);
            var reviewString = JsonSerializer.Serialize<List<Review>>(Reviews, new JsonSerializerOptions { WriteIndented = true });

            try
            {
                File.WriteAllText(filePath + "Restaurant.json", reviewString);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Please check the path, " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check the file name, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return reviewToAdd;
        }

        public Restaurant AddReview(Restaurant rest)
        {
            throw new NotImplementedException();
        }

        public List<Restaurant> GetAllRestaurants()
        {
            throw new NotImplementedException();
        }

        void IRepository.AddReview(int StoreIDs, Review reviewToAdd)
        {
            throw new NotImplementedException();
        }

        public class Review
        {
        }
    }



    public List<Restaurant> GetAllRestaurants() //Deserialization
        {
            try
            {
                jsonString = File.ReadAllText(filePath + "Restaurant.json");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Please check the path, " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check the file name, " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (!string.IsNullOrEmpty(jsonString))
                return JsonSerializer.Deserialize<List<Restaurant>>(jsonString);
            else
                return null;


        }
        
    }
}