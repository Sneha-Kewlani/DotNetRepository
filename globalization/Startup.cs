using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(globalization.Startup))]
namespace globalization
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
