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
        public UserController(IJWTManagerRepo repository)
        {
            this.repository = repository;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(User user)
        {
            var token = repository.Authenticate(user);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }
    }
}
