using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace L09_HomeWorkB1_2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public string Product { get; set; } // filter
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; } // filter
    }
}