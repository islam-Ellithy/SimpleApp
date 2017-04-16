using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegisterationWebApp.Startup))]
namespace RegisterationWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
