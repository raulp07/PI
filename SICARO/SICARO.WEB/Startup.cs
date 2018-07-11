using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SICARO.WEB.Startup))]
namespace SICARO.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
