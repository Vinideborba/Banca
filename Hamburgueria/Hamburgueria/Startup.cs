using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hamburgueria.Startup))]
namespace Hamburgueria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
