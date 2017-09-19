using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coinly.Startup))]
namespace Coinly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
