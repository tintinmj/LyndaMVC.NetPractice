using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ATM_MVC.Startup))]
namespace ATM_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
