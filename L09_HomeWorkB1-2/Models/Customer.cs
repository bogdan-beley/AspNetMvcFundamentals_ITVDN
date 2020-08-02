using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L09_HomeWorkB1_2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}