using L08_HomeWorkB.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L08_HomeWorkB.Startup))]
namespace L08_HomeWorkB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateUsersAndRoles();
        }

        public void CreateUsersAndRoles()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!RoleManager.RoleExists("SuperAdmin"))
            {
                var role = new IdentityRole("SuperAdmin");
                RoleManager.Create(role);


                var user = new ApplicationUser { UserName = "sa@domain.com", Email = "sa@domain.com" };
                

            
                string pwd = "Admin1234";
                

                UserManager.Create(user, pwd);

                UserManager.AddToRole(user.Id, "SuperAdmin");
                
                
                
            }
        }
    }
}
