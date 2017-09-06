using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspMvc.Startup))]
namespace aspMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
