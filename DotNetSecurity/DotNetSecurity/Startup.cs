using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetSecurity.Startup))]
namespace DotNetSecurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
