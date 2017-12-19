using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoneyPlanning.Startup))]
namespace MoneyPlanning
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
