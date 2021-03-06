
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHBL;
using CHModel;
using CHDL;
using ChopHouseDraftUI;

namespace ChopHouseUI
{
    public class AddRestaurantMenu : IMenu
    {
        //static non-access modifiers are needed to keep this variable consistent to all objects we create out of our AddRestaurantMenu 
        public static ChopHouse newRestaurant = new ChopHouse();

        readonly IChopHouseLogic logic;

        public AddRestaurantMenu(IChopHouseLogic logic) //constructor with argument is getting connection from program.cs sending to function with logic
        {
            this.logic = logic;
        }
        public void Display()
        {
            Console.WriteLine("Enter Restaurant Information");
            Console.WriteLine("<0> Go Back to MainMenu");
            Console.WriteLine("<1> Name - " + newRestaurant.Name);
            Console.WriteLine("<2> City - " + newRestaurant.City);
            Console.WriteLine("<3> State - " + newRestaurant.State);
            /*Console.WriteLine("<4> Rating - " + newRestaurant.Rating);
            Console.WriteLine("<5> Review - " + newRestaurant.Review);
            Console.WriteLine("<6> NumRatings - " + newRestaurant.NumRatings);*/
            Console.WriteLine("<4> StoreID - " + newRestaurant.StoreID);
            Console.WriteLine("<5> Save Restaurant");

            
        }
        public string UserChoice()
        {
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("");
            //var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Log.Information("Returning to Main Menu");
                    return "MainMenu";
                case "1":

                    try
                    {
                        Log.Information("Adding a Restaurant - " + newRestaurant.Name);
                        Console.Write("Please enter a Restaurant Name");
                        newRestaurant.Name = Console.ReadLine();
                        Log.Information("Restaurant added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add restaurant");
                        Console.WriteLine(ex.Message);
                    }
                    return "AddRestaurantMenu";
                case "2":
                    try
                    {
                        Log.Information("Adding Restaurant City - " + newRestaurant.City);
                        Console.Write("Please enter Restaurant City");
                        newRestaurant.City = Console.ReadLine();
                        Log.Information("City added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add restaurant City");
                        Console.WriteLine(ex.Message);
                    }
                    return "AddRestaurantMenu";
                case "3":
                    try
                    {
                        Log.Information("Adding Restaurant State - " + newRestaurant.State);
                        Console.Write("Please enter Restaurant State");
                        newRestaurant.State = Console.ReadLine();
                        Log.Information("State added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add restaurant State");
                        Console.WriteLine(ex.Message);
                    }
                    return "AddRestaurantMenu";
                case "4":
                    try
                    {
                        Log.Information("Adding Store ID - " + newRestaurant.StoreID);
                        Console.Write("Please enter Store ID");
                        newRestaurant.StoreID = Convert.ToInt32(Console.ReadLine());
                        Log.Information("ID added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add Store ID");
                        Console.WriteLine(ex.Message);
                    }
                    return "AddRestaurantMenu";
                case "5":
                    try
                    {
                        //ChopHouseLogic chopHouseLogic = new ChopHouseLogic();
                        Log.Information("Saving to ChopHouse.......");
                        logic.AddRestaurant(newRestaurant); //calling method AddRestaurant: to add new restaurant into the database (sqlRepository)
                        Console.Write("......Saving to Datatbase......");
                        Log.Information("Saved successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to save Restaurant");
                        Console.WriteLine(ex.Message);
                    }
                    return "MainMenu";
                default:
                    return "AddRestaurantMenu";
            }
        }
    }
}


