using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcModel2.Startup))]
namespace mvcModel2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
