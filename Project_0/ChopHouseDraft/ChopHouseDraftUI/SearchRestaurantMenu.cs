using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHDL;
using CHModel;
using CHBL;

namespace ChopHouseDraftUI
{
    public class SearchRestaurantMenu : IMenu
    {
        public static ChopHouse newSearch = new ChopHouse();

        readonly IChopHouseLogic logic; 

        
        public SearchRestaurantMenu(IChopHouseLogic logic)
        {
            this.logic = logic;
        }

        public void Display()
        {
            Console.WriteLine("Please select an option to filter the Restaurant database");
            Console.WriteLine("Press <2> By City");
            Console.WriteLine("Press <1> By Name");
            Console.WriteLine("Press <0> Go Back");
        }

        public string UserChoice()
        {
            
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("");
            Log.Information("Searching database for filtered Restaurants");

            switch (userInput)
            {
                case "0":
                    Log.Information("Returning to Main Menu");
                    return "MainMenu";
                case "1":
                    Console.Write("Please enter the name");
                    string name = Console.ReadLine();
                    Log.Information("Searching by name");
                    logic.SearchRestaurants(name, userInput);
                    Console.WriteLine("Press <enter> to continue");
                    return "SearchRestaurantMenu";
                case "2":
                    Console.Write("Please enter the city");
                    string s = Console.ReadLine();
                    Log.Information("Searching by city");
                    logic.SearchRestaurants(s, userInput);
                    Console.WriteLine("Press <enter> to continue");
                    return "SearchRestaurantMenu";
                default:
                    Console.WriteLine("Please press <enter> to continue");
                    return "SearchRestaurantMenu";
            }
        }
    }
}
