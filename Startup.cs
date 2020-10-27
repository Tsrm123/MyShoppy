using Owin;

namespace IdentitySample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {   // test
            ConfigureAuth(app);
        }
    }
}
