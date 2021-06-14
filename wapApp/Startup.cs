using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wapApp.Startup))]
namespace wapApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
