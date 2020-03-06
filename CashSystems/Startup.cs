using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CashSystems.Startup))]
namespace CashSystems
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
