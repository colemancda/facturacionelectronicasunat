<<<<<<< HEAD:Firmado Sunat/OpenInvoicePeruApi/Controllers/FirmarController.cs
﻿using System;
using System.Web.Http;
using OpenInvoicePeru.FirmadoSunat;
using OpenInvoicePeru.FirmadoSunat.Models;

namespace OpenInvoicePeruApi.Controllers
{
    [Authorize]
    public class FirmarController : ApiController
    {

        public FirmadoResponse Post([FromBody]FirmadoRequest request)
        {
            var response = new FirmadoResponse();

            try
            {
                var serializador = new Serializador
                {
                    RutaCertificadoDigital = request.CertificadoDigital,
                    PasswordCertificado = request.PasswordCertificado,
                    TipoDocumento = request.UnSoloNodoExtension ? 0 : 1
                };

                response.TramaXmlFirmado = serializador.FirmarXml(request.TramaXmlSinFirma);
                response.ResumenFirma = serializador.DigestValue;
                response.ValorFirma = serializador.ValorFirma;
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
    public class FirmarController : ApiController
    {

        public FirmadoResponse Post([FromBody]FirmadoRequest request)
        {
            var response = new FirmadoResponse();

            try
            {
                var serializador = new Serializador
                {
                    RutaCertificadoDigital = request.CertificadoDigital,
                    PasswordCertificado = request.PasswordCertificado,
                    TipoDocumento = request.UnSoloNodoExtension ? 0 : 1
                };

                response.TramaXmlFirmado = serializador.FirmarXml(request.TramaXmlSinFirma);
                response.ResumenFirma = serializador.DigestValue;
                response.ValorFirma = serializador.ValorFirma;
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
>>>>>>> 38f2962290b18a733ca1c60a39764d1f12b06c03:OpenInvoicePeru/OpenInvoicePeru.WebApi/Controllers/FirmarController.cs
