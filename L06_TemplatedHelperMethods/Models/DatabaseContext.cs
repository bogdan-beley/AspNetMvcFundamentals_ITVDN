using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace L06_TemplatedHelperMethods.Models
{
    public class DatabaseContext : DbContext
    {
    public DatabaseContext() : base("DatabaseContext") { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}