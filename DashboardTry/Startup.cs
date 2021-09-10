using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DashboardTry.Startup))]
namespace DashboardTry
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
