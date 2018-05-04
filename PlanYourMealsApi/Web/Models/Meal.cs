using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int CreatedBy { get; set; }
        public int CretedAt { get; set; }
        public string Localization { get; set; }     
        public string Avatar { get; set; }
        public List<User> Users { get; set; }
    }
}