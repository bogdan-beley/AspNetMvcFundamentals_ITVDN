using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace L08_HomeWorkB1_2.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public DateTime RegisterDate { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext()
            : base("IdentitySampleDb3", throwIfV1Schema: false)
        {
        }

        public class AppDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
        {
            protected override void Seed(ApplicationDbContext context)
            {
                var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
                var roleManager = new ApplicationRoleManager(new RoleStore<ApplicationRole>(context));
                

            // Creating Roles.
                var role1 = new ApplicationRole { Name = "SuperAdmin" };
                var role2 = new ApplicationRole { Name = "Admin" };
                var role3 = new ApplicationRole { Name = "Customer" };

                roleManager.Create(role1);
                roleManager.Create(role2);
                roleManager.Create(role3);

                // Creating SuperAdmin user.
                var superAdmin = new ApplicationUser()
                {
                    Email = "sa@domain.com",
                    UserName = "sa@domain.com",
                    RegisterDate = new DateTime(2000, 1, 1)
                };

                string password = "qwerT123#";
                var result = userManager.Create(superAdmin, password);

                if (result.Succeeded)
                {
                    userManager.AddToRole(superAdmin.Id, role1.Name);
                    userManager.AddToRole(superAdmin.Id, role2.Name);
                    userManager.AddToRole(superAdmin.Id, role3.Name);
                }

                base.Seed(context);
            }
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}