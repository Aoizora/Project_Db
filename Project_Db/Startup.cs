using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_Db.Startup))]
namespace Project_Db
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
