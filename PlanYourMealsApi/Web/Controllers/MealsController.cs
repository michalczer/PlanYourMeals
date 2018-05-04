using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Web.Models;

namespace Web.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]

    public class MealsController : ApiController
    {
        // GET: api/Meals
        public IEnumerable<Meal> Get()
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
            var meals = new List<Meal>()
            {
                new Meal()
                {
                    Id = 1,
                    Name = "First meal",
                    Description = "This is first meal",
                    Date = new DateTime(2018, 04, 26, 9, 12, 00),
                    CreatedBy = 1,
                    Localization = "Krakow",
                    Avatar = "svg-1",
                    Users = users
                },
                new Meal()
                {
                    Id = 2,
                    Name = "Second meal",
                    Description = "This is second meal",
                    Date = new DateTime(2018, 04, 27, 9, 12, 00),
                    CreatedBy = 1,
                    Localization = "Krakow",
                    Avatar = "svg-2",
                    Users = users
                },
                new Meal()
                {
                    Id = 3,
                    Name = "Third meal",
                    Description = "This is third meal",
                    Date = new DateTime(2018, 04, 28, 9, 12, 00),
                    CreatedBy = 1,
                    Localization = "Krakow",
                    Avatar = "svg-3",
                    Users = users
                },
            };
            return meals;
        }

        // GET: api/Meals/5
        public Meal Get(int id)
        {
            return new Meal()
            {
                Id = 1,
                Description = "First meal",
                Date = new DateTime(2018, 04, 26, 9, 12, 00),
                CreatedBy = 1,
                Localization = "Krakow"
            };
        }

        // POST: api/Meals
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Meals/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Meals/5
        public void Delete(int id)
        {
        }
    }
}
