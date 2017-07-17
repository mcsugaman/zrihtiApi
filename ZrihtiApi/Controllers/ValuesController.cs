using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;

namespace ZrihtiApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IFrontendBusiness _frontendBusiness;

        public ValuesController(IFrontendBusiness frontendBusiness)
        {
            _frontendBusiness = frontendBusiness;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //return new string[] { _frontendBusiness.test().Name };
            //return new string[] { _frontendBusiness.getString(), _frontendBusiness.getString() };
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
