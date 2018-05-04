using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class UserMeal
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MealsId { get; set; }

    }
}