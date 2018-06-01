using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserCenter.DTO;
using UserCenter.IService;

namespace UserCenter.OpenApi.Controllers
{
    //[Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IUserService userService;
        private IGroupService groupService;
        public ValuesController(IUserService userService, IGroupService groupService)
        {
            this.userService = userService;
            this.groupService = groupService;
        }

        // GET api/values/5
        [HttpGet]
        public async Task<string> Post(string mobile, string password)
        {
            long res= await userService.Add(mobile,password);
            return res.ToString();
        }

        // POST api/values
        [HttpGet]
        public async Task<GroupDTO[]> GetGroups()
        {
            //string str=null;
            //str.ToString();
            return await groupService.GetGroupByUserIdAsync(5);
        }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
