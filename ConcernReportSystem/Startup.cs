using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConcernReportSystem.Startup))]
namespace ConcernReportSystem
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
