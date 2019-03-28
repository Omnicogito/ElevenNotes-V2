using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElevensNote.MVC.Startup))]
namespace ElevensNote.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
