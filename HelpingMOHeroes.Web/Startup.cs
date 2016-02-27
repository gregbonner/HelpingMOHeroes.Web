using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelpingMOHeroes.Web.Startup))]
namespace HelpingMOHeroes.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
