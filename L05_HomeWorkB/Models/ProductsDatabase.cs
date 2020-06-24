using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L05_HomeWorkB.Models
{
    public class ProductsDatabase
    {
        public static List<Product> Products
        {
            get
            {
                List<Product> products = new List<Product>();

                for (int i = 0; i < 20; i++)
                {
                    products.Add(new Product()
                    {
                        Id = i,
                        Name = "Product" + $"{i}",
                        Price = 15M + i,
                        Description = $"Description for Product {i}. Description for Product {i}. Description for Product {i}. Description for Product {i}."
                    });
                }

                return products;
            }
        }
    }
}