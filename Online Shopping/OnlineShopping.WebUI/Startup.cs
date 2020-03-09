using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineShopping.WebUI.Startup))]
namespace OnlineShopping.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
