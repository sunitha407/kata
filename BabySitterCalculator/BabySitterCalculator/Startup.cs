using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BabySitterCalculator.Startup))]
namespace BabySitterCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
