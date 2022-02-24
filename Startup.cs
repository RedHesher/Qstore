using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Qstore.Startup))]
namespace Qstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
