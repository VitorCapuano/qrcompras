using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QrCompras.Startup))]
namespace QrCompras
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
