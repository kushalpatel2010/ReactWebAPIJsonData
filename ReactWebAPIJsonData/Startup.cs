using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReactWebAPIJsonData.Startup))]
namespace ReactWebAPIJsonData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
