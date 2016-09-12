using System.Web;
using System.Web.Mvc;
//using RequireHttpsAttribute = OpenInvoicePeruApi.Filters.RequireHttpsAttribute;

namespace OpenInvoicePeruApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new RequireHttpsAttribute());
        }
    }
}