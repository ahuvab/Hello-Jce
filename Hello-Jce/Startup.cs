using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hello_Jce.Startup))]
namespace Hello_Jce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
