using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GunjanPersonal.Startup))]
namespace GunjanPersonal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
