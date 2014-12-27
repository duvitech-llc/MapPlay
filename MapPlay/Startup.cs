using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapPlay.Startup))]
namespace MapPlay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
