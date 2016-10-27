using System.Web.Http;
<<<<<<< HEAD:Firmado Sunat/OpenInvoicePeruApi/App_Start/WebApiConfig.cs
using Microsoft.Owin.Security.OAuth;
=======
>>>>>>> 38f2962290b18a733ca1c60a39764d1f12b06c03:OpenInvoicePeru/OpenInvoicePeru.WebApi/App_Start/WebApiConfig.cs

namespace OpenInvoicePeru.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Enforce HTTPS
            config.Filters.Add(new Filters.RequireHttpsAttribute());
        }
    }
}
