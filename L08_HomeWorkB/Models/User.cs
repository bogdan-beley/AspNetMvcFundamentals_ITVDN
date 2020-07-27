using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L08_HomeWorkB.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
    }
}