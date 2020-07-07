using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace L07_ModelBindingAndValidation.Models
{
    public class Account
    {
        [Display(Name = "Логін")]
        public string Login { get; set; }

        [Display(Name = "Пароль"), DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Підтвердити пароль"), DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}