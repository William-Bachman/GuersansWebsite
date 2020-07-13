using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GMvcWebsite.Startup))]
namespace GMvcWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
