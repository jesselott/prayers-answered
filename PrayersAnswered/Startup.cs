using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrayersAnswered.Startup))]
namespace PrayersAnswered
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
