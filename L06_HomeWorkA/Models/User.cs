using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace L06_HomeWorkA.Models
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Логін")]
        public string Login { get; set; }
        
        [Display(Name = "Повне ім'я")]
        public string FullName { get; set; }
        
        [UIHint("Password")]
        public string Password { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }
    }
}