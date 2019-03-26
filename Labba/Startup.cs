using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labba.Startup))]
namespace Labba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
