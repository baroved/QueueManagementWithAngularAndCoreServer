using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiAngular.Model;

using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using Microsoft.AspNetCore.Cors;
using ApiAngular.Infra;

namespace ApiAngular.Controllers
{

    
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    
    public class ValuesController : ControllerBase
    {
        private IServiceUser _iServiceUser;
        public ValuesController(IServiceUser iServiceUser)
        {
            this._iServiceUser = iServiceUser;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet("GetQueueArray")]
        public ActionResult<List<User>> GetAllUsersInArray()
        {
            return _iServiceUser.GetAllUsersInArray();
        }

        
        [HttpPost("AddUser")]
        public ActionResult<List<User>> AddUser(User newUser)
        {
           return _iServiceUser.AddUser(newUser);
        }
        [HttpPost("DeleteUser")]
        public ActionResult<List<User>> RemoveUser()
        {
            return _iServiceUser.DeleteUser();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
