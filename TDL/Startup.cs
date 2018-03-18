using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDL.Startup))]
namespace TDL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
