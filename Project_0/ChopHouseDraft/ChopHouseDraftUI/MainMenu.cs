using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChopHouseDraftUI
{
    
    public class MainMenu : IMenu
    {
        public interface IUser
        {
            void MainMenu();
        }
        public void Display()
        {
            Console.WriteLine("Welcome to my Restaurant App");
            Console.WriteLine("How would you like to proceed?");
            Console.WriteLine("Press <6> Login");//LoginMenu
            Console.WriteLine("Press <5> Create an Account");//create account
            Console.WriteLine("Press <4> Display all Restaurants");
            Console.WriteLine("Press <3> Search Restaurant");//Search
            Console.WriteLine("Press <2> Add Review to ChopHouse Restaurants");
            Console.WriteLine("Press <1> Add Restaurant to ChopHouse"); //Add
            Console.WriteLine("Press <0> to exit ");
        }

        public string UserChoice()
        {
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("end of input");

            switch (userInput)
            {
                case "0":
                    return "Exit";
                case "1":
                    return "AddRestaurant";
                case "2":
                    return "AddHouseReview";
                case "3":
                    return "SearchRestaurant";
                case "4":
                    return "GetAllRestaurants";
                case "5":
                    return "CreateAccount";
                case "6":
                    return "Login";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <Enter> to continue");
                    return "MainMenu";

            }
        }

    }
}
