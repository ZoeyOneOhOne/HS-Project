using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HSVersion1.Startup))]
namespace HSVersion1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
