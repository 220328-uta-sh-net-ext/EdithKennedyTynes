using SayWhaaatModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace SayWhaaatDL
{
    public class Repository : IRepository
    {
        private string filePath = "../SayWhaaatDL/Database/";
        private string jsonString;

        public Restaurant AddRestaurant(Restaurant restaurant) //Serialization 'Restaurant' is the parameter that was passed.
        {
            {
                var restaurants=AllSayWhaaats(); //adding SayWhaaat, storing them in a variable (var)
                restaurants.Add(restaurant);
                var restaurantString=JsonSerializer.Serialize<List<Restaurant>>(restaurants);
                File.WriteAllText(filePath + "Restaurant.json", restaurantString);
                return restaurant;
            }
        }

        public List<Restaurant> AllSayWhaaats() //Deserialization
        {
            try
            {
                jsonString = File.ReadAllText(filePath + "SayWhaaat.json");
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("Please check the path, "+ex.Message);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Please check the file name, " +ex.Message);
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