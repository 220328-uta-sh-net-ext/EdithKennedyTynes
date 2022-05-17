using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;///using same controller for MVC as API
using CHBL;
using CHModel;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using ChopHouseAPI.Repository;

namespace ChopHouseAPI.Controllers
{
    //Routes are used to configure the endpoints of the api, we can keep it predefined as in the standard or even customized it 
    [Route("api/[controller]")]
    //Anything in the [] is known as a decorator/attribute : its like processing before the class or methdod
    //URI uniform resource identifier, how do you identify a resource...a unique URL
    //URL uniform resource locator
    [ApiController]
    //[Authorize] //Authenticate user 401 error code if not authorized
    
    public class CHController : ControllerBase // Controller base class has the logic to interact with HTTP and communication with client  
    {
        private readonly IJWTManagerRepo repository;
        private IChopHouseLogic _chopBL;
        private IMemoryCache memoryCache;
        /// <summary>
        /// prior to access Key/Token goes through the
        /// contructor(injection dependency)
        /// </summary>
        /// <param name="_chopBL"></param>
        /// <param name="memoryCache"></param>
        public CHController(IChopHouseLogic _chopBL, IMemoryCache memoryCache, IJWTManagerRepo repository)//Constructor injection Dependency
        {
            this._chopBL = _chopBL;
            this.memoryCache = memoryCache;
            this.repository = repository;
        }


        private static List<ChopHouse> _chBL = new List<ChopHouse>
        {
            new ChopHouse {StoreID = "CH9632", Name = "Golden Dragon", City = "Norfolk", State = "VA" },
            new ChopHouse {StoreID = "CH9633", Name = "Golden Rays", City = "Norfolk", State = "VA"},
        };
        /// <summary>
        /// Returns the restaurants in ChopHouse Database
        /// </summary>
        /// <returns></returns>
        [Authorize]//Authenticate user 401 error code if not authorized, placing here none of the methods will be visible

        //Action Methods : ways to access or manipulate the resources, its uses the HTTP VERBS/methods(GET, PUT, POST, DELETE, PATCH, HEAD etc....)
        [HttpGet]//Http method mentioned exclusively in [] http method [HttpPut], [HttpPost], [HttpDelete]
        /*[Http] Nethod*/
        [ProducesResponseType(200, Type = typeof(List<ChopHouse>))]


        //public async Task<ActionResult<List<ChopHouse>>> Get()
        //public ActionResult<List<ChopHouse>> Get()  
        //***GET METHOD*** needs a parameter to be passed before we can process any value
        public ActionResult<List<ChopHouse>> Get()
        {
            List<ChopHouse> chophouses = new List<ChopHouse>();
            try
            {
                if(!memoryCache.TryGetValue("chopList", out chophouses))// any restaurants will be stored in the chophouses parameter
                {
                    chophouses = _chopBL.SearchAll();
                }   memoryCache.Set("choplist", chophouses, new TimeSpan(0, 1 ,0));// 1 min
               
            }
            catch(SqlException ex)
            {
                return NotFound(ex. Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(chophouses);
        }
       
        [HttpGet("name")]// passing value in name 
        [ProducesResponseType(200, Type = typeof(ChopHouse))] 
        [ProducesResponseType(404)]
        // not an explicit method call, its being called through HTTP request to the methods and then it looks for the/ some parameter(s), EVERY ACTION METHOD looks for some values
        //[Authorize]
        public ActionResult<ChopHouse> Get(string name)//primitive type so model binder will look for these values as querystring "name parameter" model binding" parameter binding an entity
        { //model binding" parameter binding an entity that automatically maps Json objects coming from HTTP (i.e. Postman) into the C# model
            var rest = _chopBL.SearchRestaurants(name);
            //var rest = _chBL.Find(x => x.Name.Contains(name)); //LINQ query using Lambdas expression 
            //^stored in variable 
            //if (rest == null)
            //if (rest == null || rest.Any()) // in body results were []
            if(rest.Count<=0)
                return NotFound($"Restaurant {name} you are looking for is not found in database");
            return Ok(rest);
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]


        /// <summary>
        /// COMPLEX TYPE Request of values REQUEST [FromBody], parameters passed to (rest) "rest parameter" ([FromBody] someModel) 
        /// is the MAGIC Method that does model binding operation
        /// </summary>
        /// <param name="rest"></param>
        /// <returns>Model binging operation</returns>
        public ActionResult Post([FromBody] ChopHouse rest)//complex type model binder will look for these values from request body
        {
            if (rest == null)//condition check 
                return BadRequest("Invalid Restaurant, try again with valid values");
            _chopBL.AddRestaurant(rest);//_chBL.Add(rest); (restaurants added to (rest)
            return CreatedAtAction("Get", rest);
        }

        [HttpPut] // BE SURE TO CHANGE Verbs must match in code block 
        
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        //public ActionResult Put([FromQuery]ChopHouse rest, [FromBody]string name)//non-Default asks for values from query and the body is used to pass the rest of the values
        /*Default: public ActionResult Put(ChopHouse rest,string name)Default*/

        /// <summary>
        ///User not permitted to use make a [Put] request
        /// </summary>
        /// <returns>authenticate at Action level</returns>
        //[Authorize]

        public ActionResult Put([FromBody]/*or [FromQuery]*/ ChopHouse rest, string name)//[Put]METHOD: storing the values from [BODY/QUERY]. [FromRoute], [Put]updates restaurant.. to change restaurant by its name 
        {
            if (name == null)//condition check 
                return BadRequest("Cannot Modify without name, try again with name value"); // if changed to status code 404 "Restaurant name cannot be found....
            try
            {
                var chophouse = _chBL.Find(x => x.Name.Contains(name)); //_chBL.Remove(rest);
                                                                        //_chBL.Add(rest);
                if (chophouse == null)
                    return NotFound("Restaurant NOT FOUND");// bad request can be interchanged with <NotFound> code 404
                chophouse.StoreID = rest.StoreID;
                chophouse.Name = rest.Name;
                chophouse.City = rest.City;
                chophouse.State = rest.State;
                /*chophouse.Rating = rest.Rating;
                chophouse.Review = rest.Review;
                chophouse.NumRatings = rest.NumRatings;*/
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Created("Get", rest);// return Created("Get",rest); ... to return status code 201

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
