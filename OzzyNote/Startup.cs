using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OzzyNote.Startup))]
namespace OzzyNote
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
