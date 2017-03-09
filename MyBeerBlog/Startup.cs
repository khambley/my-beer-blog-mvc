using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyBeerBlog.Startup))]
namespace MyBeerBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
