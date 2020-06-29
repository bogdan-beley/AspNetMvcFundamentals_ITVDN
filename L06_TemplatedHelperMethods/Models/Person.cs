using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L06_TemplatedHelperMethods.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Enum Role { get; set; }
    }

    public enum Role
    {
        Guest,
        Admin,
        User
    }
}