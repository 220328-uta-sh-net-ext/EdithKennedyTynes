// See https://aka.ms/new-console-template for more information
global using Serilog;
using ChopHouseUI;
using ChopHouseBL;
using System;
using ChopHouseDL;

bool repeat = true;
IMenu menu = new MainMenu();

string connectinStringFilePath = "C:/Revature/Project_0/ChopHouse/ChopHouseDL/Connection-string.txt";
string connectinString = File.ReadAllText(connectinStringFilePath);
//IRepositoryUser UserRepo = new UserRepo(connectinStrring);
//IUserLogic Userlogic = new UserLogic(UserRepo);
//SQLRepository SqlRepo = new SQLRepository(connectinString);
IRepository Repo = new SQLRepository(connectinString);// an object of the class in the sql repository
IChopHouseLogic Rlogic = new ChopHouseLogic(Repo);


Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("C:/Revature/Project_0/ChopHouse/ChopHouseUI/Logs.txt")
    .CreateLogger();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "AddRestaurant":
            Log.Debug("redirecting user to AddRestaurant Menu");
            menu = new AddRestaurantMenu();
            break;
        case "SearchRestaurant":
            Log.Debug("Redirecting user to Search Menu");
            menu = new SearchRestaurantMenu(); //
            break;
        case "GetRestaurants":
            Log.Debug("Displaying all Restaurants to the user");
            Console.WriteLine("~~~Retreiving all Restaurants~~~");
            menu = new SearchRestaurantMenu();
            break;
        case "CreateAccount":
            Log.Debug("Promted user to create an account");
            Console.WriteLine("~~~Welcome to Account Registration~~~");
            break;
        case "Login":
            Log.Debug("Redirected to Account Login");
            Console.WriteLine("~~~Welcome to Account Login~~~");
            break;
        case "MainMenu":
            Log.Debug("Displaying MainMenu to the User");
            menu = new MainMenu();
            break;
        default:
            Console.WriteLine("Please Press <Enter> to continue");
            break;
    }
}
