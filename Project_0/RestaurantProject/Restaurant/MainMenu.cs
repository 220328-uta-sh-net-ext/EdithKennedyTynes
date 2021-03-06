using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUI
{
    class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to my Restaurant App");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press <6> ");
            Console.WriteLine("Press <5> Login");//LoginMenu
            Console.WriteLine("Press <3> Create an Account");//create account
            Console.WriteLine("Press <2> Search Restaurant");//Search 
            Console.WriteLine("Press <1> Add Restaurant to your database"); //Add
            Console.WriteLine("Press <0> to exit ");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "Add a Restaurant";
                case "2":
                    return "Search for a Restaurant";
                default:
                    break;
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <Enter> to continue");
            }
            return "MainMenu";
        }
    }
}
