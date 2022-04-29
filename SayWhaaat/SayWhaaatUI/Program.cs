// See https://aka.ms/new-console-template for more information;
global using Serilog;
using SayWhaaatUI;
using System;

bool repeat = true;
MainMenu menu = new MainMenu();


while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {

        case "SearchSayWhaaat":
            //call SearchSayWhaaat method
            Console.WriteLine("SearchSayWhaaat() Method implementation is in progress.... ");
            break;

        case "AddRestaurantToSayWhaaat":
            menu = new AddRestaurantMenu();
            Console.WriteLine("----------Restaurant Added----------");
            break;
        case "GetAllRestaurants":
            Console.WriteLine("---------Retreiving all pokemons---------");
            SayWhaaatOperations.GetAllRestaurants();
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;

        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("View Does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;


    }
}