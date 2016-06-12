using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestGitTool.Startup))]
namespace TestGitTool
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
