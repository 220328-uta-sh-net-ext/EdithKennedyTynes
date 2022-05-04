using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChopHouseUI;

namespace ChopHouseUI
{
    internal class SearchRestaurantMenu : IMenu
    {
 
        
           // ChopHouseLogic repo = new ChopHouseLogic();
            public void Display()
            {
                Console.WriteLine("Please select an option to filter the Restaurant database");
                Console.WriteLine("Press <1> By Name");
                Console.WriteLine("Press <0> Go Back");
            }

            public string UserChoice()
            {
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        return "MainMenu";
                    case "1":
                        Console.Write("Please enter the name");
                        string name = Console.ReadLine();
                        /*var results = repo.SearchRestaurants(name);
                        if (results.Count() > 0)
                        {
                            foreach (var r in results)
                            {
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine(r.ToString());

                            }
                        }
                        else
                        {
                            Console.WriteLine($"Restaurant with search string {name} not found");
                        }*/

                        Console.WriteLine("Press <enter> to continue");
                        Console.ReadLine();
                        return "MainMenu";
                    default:
                        Console.WriteLine("Please enter a valid response");
                        Console.WriteLine("Please press <enter> to continue");
                        Console.ReadLine();
                        return "SearchRestaurant";
                }
            }
        
    }
}
