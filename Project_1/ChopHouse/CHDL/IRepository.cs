using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHModel;


namespace CHDL
{
    public interface IRepository
    {
        public ChopHouse AddRestaurant(ChopHouse rest); //Method to add restaurant CALLING ONE 


        public HouseReview AddHouseReview(HouseReview view);// method to add review 
        public List<ChopHouse> SearchRestaurants();// method to view a restaurants filtered in database and return them as a generic list... CALLING A COLLECTION 

        public List<ChopHouse> GetAllChopHouses();
        Task<List<ChopHouse>> GetAllChopHouseAsync();

        //List<ChopHouse>? SearchRestaurants();
    }
    public interface IRepositoryUser
    {
        //void Save(User Create);

        //void Save(User login);
        Task<List<ChopHouse>> GetAllChopHouseAsync();

        /// <summary>
        /// creating user with properties
        /// </summary>
        /// <param name="Create"></param>
        /// <returns></returns>
        public User CreateUser(User Create);

        /// <summary>
        /// methods used for the user; username and attempt to implement SOLID Principle: Simple Responsibility Principle
        /// input parameter string with login properties and responsibilities 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        bool Login(User login);


        interface Ilog
        {
            void LogError(string error);

        }
        /// <summary>
        /// input parameter string with login properties and responsibilities
        /// </summary>
        interface IEmail
        {
            bool SendEmail(string emailContent);
        }
    }
}
