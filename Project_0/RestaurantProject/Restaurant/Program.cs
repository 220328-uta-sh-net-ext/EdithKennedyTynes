// See https://aka.ms/new-console-template for more information
global using Serilog;
using RestaurantUI;
using Serilog;
using System;

bool repeat = true;
IMenu menu = new MainMenu();

Log.Logger = new LoggerConfiguration()
   .MinimumLevel.Debug()
   .WriteTo.File("C:/Revature/Project_0/RestaurantProject/Restaurant/Logs.txt").MinimumLevel.Debug().MinimumLevel.Information()
   .CreateLogger();


while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "AddReview":
            RestaurantOperations.AddReview();
            Console.WriteLine("....");
            break;
        case "SearchRestaurant":
            RestaurantOperations.GetAllRestaurants();
            Console.WriteLine("....");
            break;
        case "AddRestaurant":
            RestaurantOperations.AddRestaurant();
            System.Console.WriteLine("....");
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}

