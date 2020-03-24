using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(App2.Startup))]
namespace App2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
