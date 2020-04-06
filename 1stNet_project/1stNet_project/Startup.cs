using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1stNet_project.Startup))]
namespace _1stNet_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
