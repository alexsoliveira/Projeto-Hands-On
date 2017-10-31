using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteHandsonCurriculum.UI.Web.Startup))]
namespace TesteHandsonCurriculum.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
