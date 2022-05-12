﻿using Microsoft.AspNetCore.Http;
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
            new ChopHouse {StoreID = "CH9632", Name = "Golden Dragon", City = "Norfolk", State = "VA" },
            new ChopHouse {StoreID = "CH9633", Name = "Golden Rays", City = "Norfolk", State = "VA"},
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

        public ActionResult Put([FromBody] ChopHouse rest, string name)//[Put] [FromRoute] update restaurant.. to change restaurant by its name 
        {
            if (name == null)//condition check 
                return BadRequest("Cannot Modify without name, try again with name value"); // if changed to status code 404 "Restaurant name cannot be found....
            var chophouse = _chBL.Find(x => x.Name.Contains(name));
            if (chophouse == null)
                return NotFound("Restaurant NOT FOUND");// bad request can be interchanged with <NotFound> code 404
            chophouse.StoreID = rest.StoreID;
            chophouse.Name = rest.Name;
            chophouse.City = rest.City;
            chophouse.State = rest.State;
            /*chophouse.Rating = rest.Rating;
            chophouse.Review = rest.Review;
            chophouse.NumRatings = rest.NumRatings;*/
            

            //_chBL.Remove(rest);
            //_chBL.Add(rest);
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
