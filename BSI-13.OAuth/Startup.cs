using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BSI_13.OAuth.Startup))]
namespace BSI_13.OAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
