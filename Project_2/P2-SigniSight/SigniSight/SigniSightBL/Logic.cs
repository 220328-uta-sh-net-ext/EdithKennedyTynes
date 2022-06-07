using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SigniSightModel;
using SigniSightBL;
using SigniSightDL;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

namespace SigniSightBL
{
    public class Logic : ILogic
    {
        private readonly IRepo _repo;
        public Logic(IRepo _repo)
        {
            this._repo = _repo;
        }

        public User AddUser(User userToAdd)
        {
            return _repo.AddUser(userToAdd);
        }


        public bool Authenticate(User user)
        {
            List<User> users = _repo.GetAllUsers();
            if (users.Exists(auth => auth.Username == user.Username && auth.Password == user.Password))
                return true;
            else
                return false;
        }

        public List<User> GetUserAccount(string Username, string Password)
        {
            List<User> users = _repo.GetAllUsers();
            var filteredUsernames = users.Where(user => user.Username.ToLower().Equals(Username)
            && user.Password.ToLower().Equals(Password)).ToList();
            return filteredUsernames;
        }
        
    }
}