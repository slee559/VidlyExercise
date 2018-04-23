using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyExercise.Startup))]
namespace VidlyExercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
