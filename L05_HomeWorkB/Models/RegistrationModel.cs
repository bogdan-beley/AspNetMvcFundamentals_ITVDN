using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L05_HomeWorkB.Models
{
    public class RegistrationModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPass { get; set; }
        public string Email { get; set; }
    }
}