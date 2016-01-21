using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyAzureWebsite.Startup))]
namespace MyAzureWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
