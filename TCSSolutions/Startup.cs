using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TCSSolutions.Startup))]
namespace TCSSolutions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
