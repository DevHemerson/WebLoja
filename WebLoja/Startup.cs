using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebLoja.Startup))]
namespace WebLoja
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
