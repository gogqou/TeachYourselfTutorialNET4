using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrototypeMVCForm.Startup))]
namespace PrototypeMVCForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
