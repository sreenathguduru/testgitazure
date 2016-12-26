using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(helloworldgit.Startup))]
namespace helloworldgit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
