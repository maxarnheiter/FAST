using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FAST.Startup))]
namespace FAST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
