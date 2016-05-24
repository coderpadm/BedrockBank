using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BedrockBankUI.Startup))]
namespace BedrockBankUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
