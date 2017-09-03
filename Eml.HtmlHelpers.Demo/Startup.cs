using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eml.HtmlHelpers.Demo.Startup))]
namespace Eml.HtmlHelpers.Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
