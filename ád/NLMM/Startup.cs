using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NLMM.Startup))]
namespace NLMM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
