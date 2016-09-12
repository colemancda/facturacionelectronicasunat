using Microsoft.Owin;
using OpenInvoicePeruApi;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace OpenInvoicePeruApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}