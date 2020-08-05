using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace L09_HomeWorkB1_2.Models
{
    public class OrdersListVIewModel
    {
        public IEnumerable<Order> Orders { get; set; }

        [Display(Name = "Покупці:")]
        public SelectList Customers { get; set; }

        [Display(Name = "Продукти:")]
        public SelectList Products { get; set; }
    }
}