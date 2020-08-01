using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L09_HomeWorkA.Models
{
    public class ProductsData
    {
        public static IEnumerable<Product> Products
        {
            get
            {
                List <Product> list = new List<Product>();
                for (int i = 1; i <= 15; i++)
                {
                    list.Add(new Product { Id = i.ToString(), ProductName = ($"Product {i}") });
                }

                return list;
            }
        }


    }
}