// See https://aka.ms/new-console-template for more information
global using Serilog;
using CHBL;
using CHDL;
using CHModel;
using ChopHouseDraftUI;
using System;

bool repeat = true;
IMenu menu = new MainMenu();


string connectionStringFilePath = "C:/Revature/Project_0/ChopHouseDraft/CHDL/Connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

IRepositoryUser UserRepo = new UserRepo (connectionString);
IUserLogic Userlogic = new CHUserLogic();

IRepository repo = new Repository(connectionString); // an object of the class in the sql repository
IChopHouseLogic HouseLogic = new ChopHouseLogic(repo);
//IRepository SqlRepo = new SqlRepository (connectionString);



Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("C:/Revature/Project_0/ChopHouseDraft/ChopHouseDraftUI/Logs.txt")
    .CreateLogger();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    { 
        /*case "AddReview":
            Log.Debug("Adding a Review");
            menu = new AddReview();
            Console.WriteLine(".....");
            break;*/

        case "AddRestaurant":
            Log.Debug("redirecting user to AddRestaurant Menu");
            menu = new AddRestaurantMenu(HouseLogic);
            break;
        case "SearchRestaurant":
            Log.Debug("Redirecting user to Search Menu");
            menu = new SearchRestaurantMenu(HouseLogic); //
            break;
        case "GetRestaurants":
            Log.Debug("Displaying all Restaurants to the user");
            Console.WriteLine("~~~Retreiving all Restaurants~~~");
            menu = new SearchRestaurantMenu(HouseLogic);
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

