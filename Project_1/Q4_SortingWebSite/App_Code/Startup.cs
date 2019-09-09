using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SortingWebSite.Startup))]
namespace SortingWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
