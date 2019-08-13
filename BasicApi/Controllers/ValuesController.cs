using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BasicApi.Controllers
{
    [Route("hello/[controller]")]
    public class NamesController : Controller
    {
        [HttpGet]
        public string Get()
        {

            return "HIII";
        }

        // GET api/values/5
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return "Hi " +name;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
