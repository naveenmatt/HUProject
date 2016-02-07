using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassifiedSite_1._0.Startup))]
namespace ClassifiedSite_1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
