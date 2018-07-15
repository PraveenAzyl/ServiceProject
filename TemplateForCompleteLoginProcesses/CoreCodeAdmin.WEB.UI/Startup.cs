using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoreCodeAdmin.WEB.UI.Startup))]
namespace CoreCodeAdmin.WEB.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
