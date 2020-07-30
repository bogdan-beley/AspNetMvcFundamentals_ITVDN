using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace L09_AjaxInMvc.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("L09_OrdersDb") { }

        public DbSet<Order> Orders { get; set; }
    }
}