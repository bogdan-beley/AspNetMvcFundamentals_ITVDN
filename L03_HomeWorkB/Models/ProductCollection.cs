using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace L03_HomeWorkB.Models
{
    public class ProductCollection
    {
        public static List<Product> All
        {
            get
            {
                List<Product> products = new List<Product>();
                for (int i = 0; i < 30; i++)
                {
                    products.Add(new Product()
                    {
                        Id = i + 1,
                        Name = "Product" + " " + $"{i + 1}",
                        Price = (i + 1) * 2,
                        CreatedDate = DateTime.Now
                    });
                }
                return products;
            }
        }
    }
}