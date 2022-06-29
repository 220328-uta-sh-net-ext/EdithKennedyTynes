
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ChopHouseAPI.Repository;
using CHModel;
using Serilog;
using Microsoft.Data.SqlClient;

namespace ChopHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IJWTManagerRepo repository;
        public UserController(IJWTManagerRepo repository) //constructor injection dependency 
        {
            this.repository = repository;
        }
        private static List<ChopHouse> _chBL = new List<ChopHouse>
        {
            new ChopHouse {StoreID = 963, Name = "Golden Dragon", City = "Norfolk", State = "VA" },
            new ChopHouse {StoreID = 9633, Name = "Golden Rays", City = "Norfolk", State = "VA"},

        };


        [AllowAnonymous]// for if you any method is public we can use to secure them// can allow authentication

        [HttpPost]
        [Route("Authenticate")]
        /// <summary>
        /// new token is returned through the IActionResult
        /// </summary>
        /// <returns>token</returns>
        public IActionResult Authenticate(AdminUser aduser)
        {
            var token = repository.Authenticate(aduser);//pass aduser; provides the "Authentication" bearer token and take us to the interface
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }

        [HttpGet("SearchUser")]
        [ProducesResponseType(200, Type = typeof(User))]
        [ProducesResponseType(404)]
        public ActionResult<User> Get(string Name)
        {
            List<User> users = new List<User>();
            try
            {
                if (users.Count <= 0)
                {
                    Log.Information($"Admin searching for {users} from database");
                    return NotFound($"User {Name} you are looking for is not found in database");

                }

            }
            catch (SqlException ex)
            {
                Log.Information("SqlException Type: " + ex.Message);
                return BadRequest(ex.Message);
            }
            Log.Information($"Admin searching for {users} from database");
                        return Ok(Name);
        }

        [HttpGet("SearchUserID")]
        [ProducesResponseType(200, Type = typeof(User))]
        [ProducesResponseType(404)]

        public ActionResult<User> Get(int UserID)
        {
            List<User> userid = new List<User>();
            try
            {
                if (userid.Count <= 0)//nested if statement 
                {
                    Log.Information($"Admin searching for {userid} from database");
                    return NotFound($"User {UserID} you are looking for is not found in database");

                }

            }
            catch (SqlException ex)
            {
                Log.Information("SqlException Type: " + ex.Message);
                return BadRequest(ex.Message);
            }
            Log.Information($"Admin searching for {userid} from database");
            return Ok(UserID);
        }


        [HttpDelete]
        public ActionResult Delete(string name)
        {
            if (name == null)//condition check 
                return BadRequest("Cannot Modify without name, try again with name value"); // if changed to status code 404 "Restaurant name cannot be found....
            var chophouse = _chBL.Find(x => x.Name.Contains(name));
            if (chophouse == null)
                return NotFound("Restaurant NOT FOUND");// bad request can be interchanged with <NotFound> code 404
            _chBL.Remove(chophouse);
            return Ok($"Restaurant {name} Deleted");
        }
        
    }
}