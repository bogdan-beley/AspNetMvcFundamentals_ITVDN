using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L06_HomeWorkB2.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }
    }
}