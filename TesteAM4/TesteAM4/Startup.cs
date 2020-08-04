using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteAM4.Startup))]
namespace TesteAM4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
