using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp17.Startup))]
namespace WebApp17
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
