using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Music_Store.UI.Startup))]
namespace Music_Store.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
