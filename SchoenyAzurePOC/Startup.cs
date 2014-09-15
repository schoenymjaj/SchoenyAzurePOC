using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoenyAzurePOC.Startup))]
namespace SchoenyAzurePOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
