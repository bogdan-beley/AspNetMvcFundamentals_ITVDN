using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace L05_HtmlHelperMethods.Models
{
    public static class ProductsDatabase
    {
        private static List<ProductDetails> _products = null;


        public static List<ProductDetails> Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new List<ProductDetails>();
                    ProductDetails details;

                    details = new ProductDetails();
                    details.Id = 1;
                    details.Name = "Apples";
                    details.Category = "Fruits";
                    details.Price = 10.99M;
                    _products.Add(details);

                    details = new ProductDetails();
                    details.Id = 2;
                    details.Name = "Bananas";
                    details.Category = "Fruits";
                    details.Price = 30.90M;
                    _products.Add(details);

                    details = new ProductDetails();
                    details.Id = 3;
                    details.Name = "Mangos";
                    details.Category = "Fruits";
                    details.Price = 100.99M;
                    _products.Add(details);

                    details = new ProductDetails();
                    details.Id = 4;
                    details.Name = "Potatoes";
                    details.Category = "Vegetables";
                    details.Price = 14.50M;
                    _products.Add(details);

                    details = new ProductDetails();
                    details.Id = 5;
                    details.Name = "Kiwi";
                    details.Category = "Fruits";
                    details.Price = 40.60M;
                    _products.Add(details);

                    details = new ProductDetails();
                    details.Id = 6;
                    details.Name = "Strawberries";
                    details.Category = "Fruits";
                    details.Price = 105.66M;
                    _products.Add(details);
                }
                return _products;
            }
        }
    }

    public class ProductDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}