using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspDotNetMvc.Startup))]
namespace aspDotNetMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
