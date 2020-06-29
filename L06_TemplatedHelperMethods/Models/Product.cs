using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace L06_TemplatedHelperMethods.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Display(Name = "Ім'я")]
        public string Name { get; set; }

        [Display(Name = "Ціна")]
        public decimal Price { get; set; }

        [Display(Name = "Наявність")]
        public bool IsAvailable { get; set; }
    }
}