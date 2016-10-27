<<<<<<< HEAD:Firmado Sunat/OpenInvoicePeruApi/Controllers/GenerarComunicacionBajaController.cs
﻿using System;
using System.Web.Http;
using OpenInvoicePeru.FirmadoSunat;
using OpenInvoicePeru.FirmadoSunat.Models;

namespace OpenInvoicePeruApi.Controllers
{
    [Authorize]
    public class GenerarComunicacionBajaController : ApiController
    {
        public DocumentoResponse Post([FromBody]ComunicacionBaja baja)
        {
            var response = new DocumentoResponse();

            try
            {
                var voidedDocument = Generador.GenerarVoidedDocuments(baja);

                var serializador = new Serializador();
                response.TramaXmlSinFirma = serializador.GenerarXml(voidedDocument);
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
=======
﻿using System;
using System.Web.Http;
using OpenInvoicePeru.Firmado;
using OpenInvoicePeru.Firmado.Models;

namespace OpenInvoicePeru.WebApi.Controllers
{
    public class GenerarComunicacionBajaController : ApiController
    {
        public DocumentoResponse Post([FromBody]ComunicacionBaja baja)
        {
            var response = new DocumentoResponse();

            try
            {
                var voidedDocument = Generador.GenerarVoidedDocuments(baja);

                var serializador = new Serializador();
                response.TramaXmlSinFirma = serializador.GenerarXml(voidedDocument);
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
>>>>>>> 38f2962290b18a733ca1c60a39764d1f12b06c03:OpenInvoicePeru/OpenInvoicePeru.WebApi/Controllers/GenerarComunicacionBajaController.cs
}