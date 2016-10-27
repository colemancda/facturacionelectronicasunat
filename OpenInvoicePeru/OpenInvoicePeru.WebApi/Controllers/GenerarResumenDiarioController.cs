<<<<<<< HEAD:Firmado Sunat/OpenInvoicePeruApi/Controllers/GenerarResumenDiarioController.cs
﻿using System;
using System.Web.Http;
using OpenInvoicePeru.FirmadoSunat;
using OpenInvoicePeru.FirmadoSunat.Models;

namespace OpenInvoicePeruApi.Controllers
{
    [Authorize]
    public class GenerarResumenDiarioController : ApiController
    {
        public DocumentoResponse Post([FromBody] ResumenDiario resumen)
        {
            var response = new DocumentoResponse();
            try
            {
                var summary = Generador.GenerarSummaryDocuments(resumen);
                var serializador = new Serializador();
                response.TramaXmlSinFirma = serializador.GenerarXml(summary);
                response.Exito = true;
            }
            catch (Exception ex)
            {
                response.Exito = false;
                response.MensajeError = ex.Message;
                response.Pila = ex.StackTrace;
            }

            return response;
        }
    }
}
=======
﻿using System;
using System.Web.Http;
using OpenInvoicePeru.Firmado;
using OpenInvoicePeru.Firmado.Models;

namespace OpenInvoicePeru.WebApi.Controllers
{
    public class GenerarResumenDiarioController : ApiController
    {
        public DocumentoResponse Post([FromBody] ResumenDiario resumen)
        {
            var response = new DocumentoResponse();
            try
            {
                var summary = Generador.GenerarSummaryDocuments(resumen);
                var serializador = new Serializador();
                response.TramaXmlSinFirma = serializador.GenerarXml(summary);
                response.Exito = true;
            }
            catch (Exception ex)
            {
                response.Exito = false;
                response.MensajeError = ex.Message;
                response.Pila = ex.StackTrace;
            }

            return response;
        }
    }
}
>>>>>>> 38f2962290b18a733ca1c60a39764d1f12b06c03:OpenInvoicePeru/OpenInvoicePeru.WebApi/Controllers/GenerarResumenDiarioController.cs
