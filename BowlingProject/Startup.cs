using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BowlingProject.Startup))]
namespace BowlingProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
