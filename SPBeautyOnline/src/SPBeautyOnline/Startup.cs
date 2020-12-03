using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SPBeautyOnline.Startup))]
namespace SPBeautyOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
