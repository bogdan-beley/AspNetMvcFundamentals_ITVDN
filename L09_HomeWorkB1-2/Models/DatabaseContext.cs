using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace L09_HomeWorkB1_2.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("L09_HomeWorkB1-2") { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}