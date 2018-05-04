using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web.Models;
using System.Web.Http.Cors;

namespace Web.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class UsersController : ApiController
    {
        // GET: api/User
        public IEnumerable<User> Get()
        {
            var users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Email = "user1@gmail.com",
                    Login = "User1"
                },
                new User()
                {
                    Id = 1,
                    Email = "user1@gmail.com",
                    Login = "User1"
                },
                new User()
                {
                    Id = 1,
                    Email = "user1@gmail.com",
                    Login = "User1"
                }
            }; 
            return users;
        }

        // GET: api/User/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
        }
    }
}
