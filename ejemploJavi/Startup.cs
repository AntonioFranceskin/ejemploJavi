using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ejemploJavi.Startup))]
namespace ejemploJavi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
