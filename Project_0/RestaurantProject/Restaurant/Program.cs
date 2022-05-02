// See https://aka.ms/new-console-template for more information
//global using Serilog;
using RestaurantUI;
using System;

bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "SearchRestaurant":
            //call SearchRestaurant method
            Console.WriteLine("SearchRestaurant() Method implementation is in progress....");
            break;
        case "AddRestaurant":
            //call AddRestaurant met
            System.Console.WriteLine("AddRestaurant() Method implementaion is in progress....");
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

