using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureTestDBFirst.Startup))]
namespace AzureTestDBFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
