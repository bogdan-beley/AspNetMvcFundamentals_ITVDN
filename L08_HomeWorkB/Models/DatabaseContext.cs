using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace L08_HomeWorkB.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("L08_ShopContext") { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}