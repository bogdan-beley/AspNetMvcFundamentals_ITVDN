using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L06_TemplatedHelperMethods.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}