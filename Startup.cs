using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projekt_Sisteme_Interneti.Startup))]
namespace Projekt_Sisteme_Interneti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
