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
        [AllowAnonymous]// for if you any method is public we can use to secure them
       
        [HttpPost]
        [Route("Authenticate")]
        public IActionResult Authenticate(AdminUser aduser)
        {
            var token = repository.Authenticate(aduser);//pass aduser
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }
    }
}
