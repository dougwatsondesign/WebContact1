using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebContact1.Startup))]
namespace WebContact1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
