using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L06_TemplatedHelperMethods.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Display(Name = "Ім'я")]
        public string FirstName { get; set; }

        [Display(Name = "Прізвище")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [ScaffoldColumn(false)]
        public bool IsApproved { get; set; }

        public List<Order> Orders { get; set; }
    }
}