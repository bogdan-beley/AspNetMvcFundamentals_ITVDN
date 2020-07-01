using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L06_HomeWorkB2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
        public int QuantityOfProducts { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}