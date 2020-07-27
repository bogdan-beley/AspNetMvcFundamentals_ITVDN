using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L08_HomeWorkB1_2.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}