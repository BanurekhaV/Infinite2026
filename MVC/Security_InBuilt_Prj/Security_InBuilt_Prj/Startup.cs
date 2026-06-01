using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Security_InBuilt_Prj.Startup))]
namespace Security_InBuilt_Prj
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
