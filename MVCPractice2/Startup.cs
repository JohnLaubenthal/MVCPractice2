using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPractice2.Startup))]
namespace MVCPractice2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
