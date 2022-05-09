using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CHBL;

namespace ChopHouseAPI.Controllers
{
    //Routes are used to configure the endpoints of the api, we can keep it predefined as in the standard or even customized it 
    [Route("api/[controller]")]
    //Anything in the [] is known as a decorator/attribute : its like processing before the class or methdod
    [ApiController]
    public class CHController : ControllerBase // Controller base class has the logic to interact with HTTP and communication with client  
    {
        //Action Methods : ways to access or manipulate the resources, its uses the HTTP VERBS/methods(GET, PUT, POST, DELETE, PATCH, HEAD etc....)
        [HttpGet]//http method [HttpPut], [HttpPost], [HttpDelete]
        /*[Http] */

        public string Get()
        {
            return "Hello World";
        }

        /*private IChopHouseLogic _chBL;

        public CHController(IChopHouseLogic _chBL);//Constructor dependency*/
    }
    
}
