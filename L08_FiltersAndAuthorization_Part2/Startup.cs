using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L08_FiltersAndAuthorization_Part2.Startup))]
namespace L08_FiltersAndAuthorization_Part2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
