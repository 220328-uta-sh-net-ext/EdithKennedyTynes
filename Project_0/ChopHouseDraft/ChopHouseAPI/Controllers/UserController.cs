using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ChopHouseAPI.Repository;
using CHModel;

namespace ChopHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IJWTManagerRepo repository;
        public UserController(IJWTManagerRepo repository) //constructor injection dependency 
        {
            this.repository = repository;
        }
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
    }   
}
