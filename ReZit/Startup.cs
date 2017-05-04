using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReZit.Startup))]
namespace ReZit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
