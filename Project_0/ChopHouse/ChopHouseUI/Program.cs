// See https://aka.ms/new-console-template for more information
global using Serilog;
using ChopHouseUI;
using ChopHouseBL;
using System;
using ChopHouseDL;

bool repeat = true;
IMenu menu = new MainMenu();

string connectinStrringFilePath = "../../../Confidential.txt";
string connectinStrring = File.ReadAllText(connectinStrringFilePath);
//IRepositoryUser UserRepo = new UserRepo(connectinStrring);
//IUserLogic Userlogic = new UserLogic(UserRepo);
IRepository Repo = new Repository(connectinStrring);
IRestaurantLogic Rlogic = new ChopHouseLogic(Repo);


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
        case "AddReview":
            //ChopHouseOperations.AddReview();
            Console.WriteLine(".....");
            break;
        case "SearchRestaurant":
            //ChopHouseOperations.GetAllRestaurants();
            Console.WriteLine(".....");
            break;
        case "AddRestaurant":
            //ChopHouseOperations.AddRestaurant();
            System.Console.WriteLine(".....");
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please Press <Enter> to continue");
            Console.ReadLine();
            break;
    }
}
