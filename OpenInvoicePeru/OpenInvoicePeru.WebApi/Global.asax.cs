<<<<<<< HEAD:Firmado Sunat/OpenInvoicePeruApi/Global.asax.cs
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
=======
﻿using System.Web.Http;
>>>>>>> 38f2962290b18a733ca1c60a39764d1f12b06c03:OpenInvoicePeru/OpenInvoicePeru.WebApi/Global.asax.cs

namespace OpenInvoicePeru.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
        }
    }
}
