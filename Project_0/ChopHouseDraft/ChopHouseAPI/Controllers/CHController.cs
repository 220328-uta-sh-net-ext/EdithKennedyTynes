using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;///using same controller for MVC as API
using CHBL;
using CHModel;

namespace ChopHouseAPI.Controllers
{
    //Routes are used to configure the endpoints of the api, we can keep it predefined as in the standard or even customized it 
    [Route("api/[controller]")]
    //Anything in the [] is known as a decorator/attribute : its like processing before the class or methdod
    //URI uniform resource identifier, how do you identify a resource...a unique URL
    //URL uniform resource locator
    [ApiController]
    public class CHController : ControllerBase // Controller base class has the logic to interact with HTTP and communication with client  
    {
        private static List<ChopHouse> _chBL = new List<ChopHouse>
        {
            new ChopHouse {Name ="Golden Dragon", City = "Norfolk", State = "VA", Rating = 5, Review = "Love it", NumRatings = 1, StoreID = "CH9632" },
            new ChopHouse {Name ="Golden Rays", City = "Norfolk", State = "VA", Rating = 5, Review = "Hate it", NumRatings = 1, StoreID = "CH9633" },
        };
        //Action Methods : ways to access or manipulate the resources, its uses the HTTP VERBS/methods(GET, PUT, POST, DELETE, PATCH, HEAD etc....)
        [HttpGet]//mentioned exclusively in [] http method [HttpPut], [HttpPost], [HttpDelete]
        /*[Http] */

        public List<ChopHouse> Get()
        {
            return _chBL;
        }
        [HttpGet("name")]// passing value in name 
        public ChopHouse Get(string name)
        {
            var rest = _chBL.Find(x => x.Name.Contains(name)); //LINQ query using Lambdas expression 
            //^stored in variable 
            if (rest == null)
                return null;
            return rest;
            

            

            


        }



    }
    
}
