using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DinhHoangNhat.Startup))]
namespace DinhHoangNhat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
