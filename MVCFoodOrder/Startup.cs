using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFoodOrder.Startup))]
namespace MVCFoodOrder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
