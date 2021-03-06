
global using Serilog;
using CHBL;
using CHDL;
using CHModel;
using ChopHouseDraftUI;
using ChopHouseUI;
using System;



bool repeat = true;
IMenu menu = new MainMenu();


string connectionStringFilePath = "C:/Revature/P1/ChopHouse/CHDL/connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);


IRepositoryUser userRepo = new UserRepository(connectionString);

//UserLogic userlogic = new UserLogic(userRepo);
IUserLogic userlogic = new UserLogic(userRepo);

IRepository Sqlrepo = new SqlRepository(connectionString); // an object of the class in the sql repository
IChopHouseLogic HouseLogic = new ChopHouseLogic(Sqlrepo);




Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("C:/Revature/P1/ChopHouse/ChopHouseUI/Logs.txt")
    .CreateLogger();


while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {

        case "AddHouseReview":
            Log.Debug("Adding a Review");
            menu = new AddHouseReview(HouseLogic);
            Console.WriteLine(".....");
            break;
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
        case "Login":
            Log.Debug("Redirected to Account Login");
            Console.WriteLine("~~~Welcome to Account Login~~~");
            //menu = new Login();
            break;
        case "RegUserMenu":
            Log.Debug("Register new User");
            Console.WriteLine("~~~Welcome to Account Registration~~~");
            //User newUser = new User();
            menu = new RegUserMenu();
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
