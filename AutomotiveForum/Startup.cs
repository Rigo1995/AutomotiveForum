using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomotiveForum.Startup))]
namespace AutomotiveForum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
