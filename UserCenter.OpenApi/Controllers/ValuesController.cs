using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserCenter.IService;

namespace UserCenter.OpenApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IUserService userService;
        public ValuesController(IUserService userService)
        {
            this.userService = userService;
        }

        // GET api/values/5
        [HttpGet]
        public async Task<string> Get(string mobile,string password)
        {
            long res= await userService.Add(mobile,password);
            return res.ToString();
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

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
