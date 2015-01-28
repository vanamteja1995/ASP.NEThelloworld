using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPHelloWorld.Startup))]
namespace ASPHelloWorld
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
