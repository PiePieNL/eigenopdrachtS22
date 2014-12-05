using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eigenopdracht.Startup))]
namespace eigenopdracht
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
