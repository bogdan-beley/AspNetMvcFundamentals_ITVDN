using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace L06_HomeWorkB2.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("ShopDbContext") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}