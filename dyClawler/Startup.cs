using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dyClawler.Startup))]
namespace dyClawler
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
