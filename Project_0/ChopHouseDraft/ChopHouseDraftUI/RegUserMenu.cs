using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHBL;
using CHDL;
using CHModel;
using ChopHouseDraftUI;

namespace ChopHouseDraftUI
{
    public class RegUserMenu : User
    {
        public static User newRegUser = new User();

        readonly IUserLogic userlogic;

        public RegUserMenu(IUserLogic userlogic)
        {
            this.userlogic = userlogic;
        }

        bool Register(string username, string password)
        {
            throw new NotImplementedException();
        }
        public User CreateUser(User Create)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            Console.WriteLine("Enter New User Information");
            Console.WriteLine("<0> Go Back to MainMenu");
            Console.WriteLine("<1> UserID - " + newRegUser.UserID);
            Console.WriteLine("<2> FirstName - " + newRegUser.FirstName);
            Console.WriteLine("<3> LastName - " + newRegUser.LastName);
            Console.WriteLine("<5> UserName - " + newRegUser.UserName);
            Console.WriteLine("<6> Password - " + newRegUser.Password);
            Console.WriteLine("<7> Email - " + newRegUser.Email);
            Console.WriteLine("<8> Save New User");

        }


        string UserChoice()
        {
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("");
            //var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    Log.Information("Returning to Main Menu");
                    return "MainMenu";
                case "1":

                    try
                    {
                        Log.Information("Adding a newRegUser - " + newRegUser.UserID);
                        Console.Write("Please enter a newRegUser UserID");
                        newRegUser.UserID = Console.ReadLine();
                        Log.Information("newRegUser Name added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to addUserID");
                        Console.WriteLine(ex.Message);
                    }
                    return "RegUserMenu";
                case "2":
                    try
                    {
                        Log.Information("Adding new user Firstname - " + newRegUser.FirstName);
                        Console.Write("Please enter Firstname");
                        newRegUser.FirstName = Console.ReadLine();
                        Log.Information(" Firstname added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add user Firstname");
                        Console.WriteLine(ex.Message);
                    }
                    return " RegUserMenu";
                case "3":
                    try
                    {
                        Log.Information("Adding  newRegUser.LastName - " + newRegUser.LastName);
                        Console.Write("Please enter User LastName");
                        newRegUser.LastName = Console.ReadLine();
                        Log.Information(" newRegUser.LastName added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add  newRegUser.LastName");
                        Console.WriteLine(ex.Message);
                    }
                    return " RegUserMenu";
                case "4":
                    try
                    {
                        Log.Information("Adding newRegUser.UserName- " + newRegUser.UserName);
                        Console.Write("Please enter newRegUser.UserName");
                        newRegUser.UserName = Console.ReadLine();
                        Log.Information("newRegUser.UserName added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add newRegUser.UserName");
                        Console.WriteLine(ex.Message);
                    }
                    return " RegUserMenu";
                case "5":
                    try
                    {
                        Log.Information("Adding newRegUser.Password - " + newRegUser.Password);
                        Console.Write("Please enter newRegUser.Password");
                        newRegUser.Password = Console.ReadLine();
                        Log.Information("newRegUser.Password added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add newRegUser.Password");
                        Console.WriteLine(ex.Message);
                    }
                    return " RegUserMenu";
                case "6":
                    try
                    {
                        Log.Information("Adding newRegUser.Email - " + newRegUser.Email);
                        Console.Write("Please enter new User.Email");
                        newRegUser.Email = Console.ReadLine();
                        Log.Information("newRegUser.Email added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add Restaurant NumRating");
                        Console.WriteLine(ex.Message);
                    }
                    return " RegUserMenu";
                case "7":
                    try
                    {
                        Log.Information("Saving to ChopHouse.......");
                        userlogic.CreateUser(newRegUser); //calling method AddRestaurant: to add new restaurant into the database (sqlRepository)
                        Console.Write("......Saving to Datatbase......");
                        Log.Information("Saved successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to save User");
                        Console.WriteLine(ex.Message);
                    }
                    return "MainMenu";
                default:
                    return "RegUserMenu";


            }




        }

    }
}
