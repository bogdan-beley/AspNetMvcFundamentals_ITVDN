using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.ModelBinding;

namespace L07_HomeWorkB.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Ім'я")]
        [Required(ErrorMessage = "Поле 'Ім'я' обов'язкове для заповнення.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ім'я повинно містити від 3 до 50 символів.")]
        public string Name { get; set; }

        [Display(Name = "Адреса")]
        [Required(ErrorMessage = "Поле 'Адреса' обов'язкове для заповнення.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Адреса повинна містити від 3 до 50 символів.")]
        public string Address { get; set; }

        [Display(Name = "Дата")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Поле 'Дата' є обов'язковим.")]
        public DateTime Date { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Поле 'Email' обов'язкове для заповнення.")]
        public string Email { get; set; }

        [Display(Name = "Умови використання")]
        [MustBeTrue(ErrorMessage = "Прийміть умови використання.")]
        public bool TermsAccepted { get; set; }
    }
}