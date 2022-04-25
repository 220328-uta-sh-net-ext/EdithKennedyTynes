// See https://aka.ms/new-console-template for more information
using SayWhaaatUI;

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
            SayWhaaatOperations.AddDummyRestaurant();
            Console.WriteLine("Actual AddRestaurant() Method implementation is in progress...This is a Dummy");
            break;
        case "AllSayWhaaatRestaurants":
            //Call SeeAllSayWhaaatRestaurants method
            SayWhaaatOperations.AllSayWhaaatRestaurants();
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