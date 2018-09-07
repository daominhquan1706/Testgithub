using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vl.Startup))]
namespace vl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
