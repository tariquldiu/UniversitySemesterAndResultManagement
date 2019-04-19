using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnivarsityManagemantSystem.Startup))]
namespace UnivarsityManagemantSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
