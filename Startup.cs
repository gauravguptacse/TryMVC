using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryMVC.Startup))]
namespace TryMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
