using SayWhaaatDL;
using SayWhaaatUI;
using SayWhaaatModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SayWhaaatBL;


namespace SayWhaaatUI
{
    internal class AddRestaurantMenu : IMenu
    {
        //static non-access modifiers are needed to keep this variable consistent to all objects created into our AddPokeMenu
        private static Restaurant newRestaurant = new Restaurant();
        private IRepository _repository = new Repository();
        public void Display()
        {
            Console.WriteLine("Please enter Restaurant information to SayWhaaat");
            Console.WriteLine("<5> Name - " + newRestaurant.Name);
            Console.WriteLine("<4> Address - " + newRestaurant.Address);
            Console.WriteLine("<3> Rating - " + newRestaurant.Rating);
            Console.WriteLine("<2> Review - " + newRestaurant.Reviews);
            Console.WriteLine("<1> Save");
            Console.WriteLine("<0> Go Back");
        }
        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "MainMenu";

                case "1":
                    try
                    {
                        Log.Information("Adding a restaurant - " + newRestaurant.Name);
                        _repository.AddRestaurant(newRestaurant);
                        Log.Information("Restaurant added successfuly");
                    }
                    catch(Exception ex)
                    {
                        Log.Warning("Failed to add Restaurant");
                        Console.WriteLine(ex.Message);
                    }
                    return "MainMenu";
                case "2":
                    Console.WriteLine("Please <Enter> Restaurant Name! ");
                    _repository.AddRestaurant(newRestaurant);
                    return "RestaurantName";
                case "3":
                    Console.Write("Please enter an Address ");
                    return "AddRestaurant";
                case "4":
                    Console.Write("Please enter a Rating! ");
                    newRestaurant.Rating = Convert.ToInt32(Console.ReadLine());
                    newRestaurant.Name = Console.ReadLine();
                    return "AddRating";
                case "5":
                    Console.Write("Please enter a Review! ");
                    newRestaurant.Name = Console.ReadLine();
                    return "AddReview";               
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddRestaurant";
            }
        }
    }
}
