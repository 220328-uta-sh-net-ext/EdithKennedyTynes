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
        [HttpGet]//Http method mentioned exclusively in [] http method [HttpPut], [HttpPost], [HttpDelete]
        /*[Http] */
        [ProducesResponseType(200, Type = typeof(List<ChopHouse>))]

        public ActionResult<List<ChopHouse>> Get()
        {
            return Ok(_chBL);
        }
        [HttpGet("name")]// passing value in name 
        [ProducesResponseType(200, Type = typeof(ChopHouse))]
        [ProducesResponseType(404)]
        public ActionResult<ChopHouse> Get(string name)
        {
            var rest = _chBL.Find(x => x.Name.Contains(name)); //LINQ query using Lambdas expression 
            //^stored in variable 
            if (rest == null)
                return BadRequest($"Restaurant {name} you are looking for is not found in database");
            return Ok(rest);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult Post([FromBody] ChopHouse rest)//Request of values from the body, parameters passed to rest 
        {
            if (rest == null)//condition check 
                return BadRequest("Invalid Restaurant, try again with valid values");
            _chBL.Add(rest);
            return CreatedAtAction("Get", rest);
        }
        [HttpPut] // BE SURE TO CHANGE Verbs must matcg in code block 
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public ActionResult Put([FromBody] ChopHouse rest)//[Put] [FromRoute] update restaurant.. to change restaurant by its name 
        {
            if (rest == null)//condition check 
                return BadRequest("Invalid Restaurant, try again with valid values"); // if changed to status code 404 "Restaurant name cannot be found....
            var chophouse = _chBL.Find(x => x.Name.Contains(rest.Name));
            if (chophouse == null)
                return BadRequest("Restaurant NOT FOUND");// bad request can be interchanged with <NotFound> code 404
            chophouse.Name = rest.Name;
            //_chBL.Remove(rest);
            _chBL.Add(rest);
            return Created("Get", rest);// return Created("Get",rest); ... to return status code 201
        }




    }
    
}
