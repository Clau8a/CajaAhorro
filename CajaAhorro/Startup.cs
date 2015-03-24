using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CajaAhorro.Startup))]
namespace CajaAhorro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
