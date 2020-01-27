using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoToMovies.Startup))]
namespace GoToMovies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
