using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Experiencia1.Startup))]
namespace Experiencia1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
