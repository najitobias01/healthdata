using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthData.Startup))]
namespace HealthData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
