using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OneStopElectronix.Startup))]
namespace OneStopElectronix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
