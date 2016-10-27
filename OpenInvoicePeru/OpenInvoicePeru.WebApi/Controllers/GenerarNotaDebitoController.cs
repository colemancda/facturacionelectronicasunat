<<<<<<< HEAD:Firmado Sunat/OpenInvoicePeruApi/Controllers/GenerarNotaDebitoController.cs
﻿using System;
using System.Web.Http;
using OpenInvoicePeru.FirmadoSunat;
using OpenInvoicePeru.FirmadoSunat.Models;

namespace OpenInvoicePeruApi.Controllers
{
    [Authorize]
    public class GenerarNotaDebitoController : ApiController
    {

        public DocumentoResponse Post([FromBody] DocumentoElectronico documento)
        {
            var response = new DocumentoResponse();
            try
            {
                var notaDebito = Generador.GenerarDebitNote(documento);

                var serializador = new Serializador();

                response.TramaXmlSinFirma = serializador.GenerarXml(notaDebito);
                response.Exito = true;
            }
            catch (Exception ex)
            {
                response.MensajeError = ex.Message;
                response.Pila = ex.StackTrace;
                response.Exito = false;
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
    public class GenerarNotaDebitoController : ApiController
    {

        public DocumentoResponse Post([FromBody] DocumentoElectronico documento)
        {
            var response = new DocumentoResponse();
            try
            {
                var notaDebito = Generador.GenerarDebitNote(documento);

                var serializador = new Serializador();

                response.TramaXmlSinFirma = serializador.GenerarXml(notaDebito);
                response.Exito = true;
            }
            catch (Exception ex)
            {
                response.MensajeError = ex.Message;
                response.Pila = ex.StackTrace;
                response.Exito = false;
            }

            return response;
        }

    }
}
>>>>>>> 38f2962290b18a733ca1c60a39764d1f12b06c03:OpenInvoicePeru/OpenInvoicePeru.WebApi/Controllers/GenerarNotaDebitoController.cs
