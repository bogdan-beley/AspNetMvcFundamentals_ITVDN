using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L08_HomeWorkB1_2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public int Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}