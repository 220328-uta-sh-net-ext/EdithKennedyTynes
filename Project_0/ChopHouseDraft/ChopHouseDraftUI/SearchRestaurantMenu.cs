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

        private IRepository _repository = new SqlRepository();

        readonly IChopHouseLogic logic; 

        public static void GetAllChopHouse()
        {
           
        }


        public SearchRestaurantMenu(IChopHouseLogic logic)
        {
            this.logic = logic;
        }

        public void Display()
        {
            Console.WriteLine("Please select an option to filter the Restaurant database");
            Console.WriteLine("Press <2> Display All"); // + newSearch.ChopHouse);
            Console.WriteLine("Press <1> By Name"); // + newSearch.Name);
            Console.WriteLine("Press <0> Go Back");
            //Console.WriteLine("Press <3> By City");
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
                    List<CHModel.ChopHouse>? results = logic.SearchRestaurants(name);
                    if (results.Count > 0)
                    {
                        foreach (CHModel.ChopHouse? r in results)
                        {
                            Console.WriteLine("=================");
                            Console.WriteLine(r.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Restaurant with search string {name} not found");
                        Log.Information("Restaurant with search string {name} not found");
                    }
                    //Console.WriteLine("Press <enter> to continue");
                    //Console.ReadLine();
                    //newSearch.Name = Console.ReadLine();
                    return "SearchRestaurantMenu";
                case "2":
                    Console.Write("Searching by All Restaurants");
                    var Chophouse = _repository.GetAllChopHouses();
                    Log.Information("Searching All ChopHouse");
                    foreach (var chophouse in Chophouse)
                    {
                            Console.WriteLine("=================");
                            Console.WriteLine(chophouse);
                            Console.WriteLine("=================");
                    }
                    return "SearchRestaurantMenu";
                default:
                    Console.WriteLine("Please enter a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    return "SearchRestaurantMenu";


            }
        }
    }
}
