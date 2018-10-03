using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LogzTest.Startup))]
namespace LogzTest
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
