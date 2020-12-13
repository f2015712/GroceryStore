using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace login.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        [Route("categories")]
        public IHttpActionResult Get([FromUri]string username,[FromUri]string password)
        {
            loginResponse response = new loginResponse();
            if(username=="sid" && password== "123"){

                response.Success = true;
            }
            else
            {
                response.Success = false;
            }
            return Ok(response);

        }

       
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
