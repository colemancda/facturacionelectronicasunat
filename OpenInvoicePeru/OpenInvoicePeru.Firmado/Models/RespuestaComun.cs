﻿namespace OpenInvoicePeru.Firmado.Models
{
    public abstract class RespuestaComun
    {
        public bool Exito { get; set; }
        public string MensajeError { get; set; }
        public string Pila { get; set; }
        public string NombreArchivo { get; set; }
    }
}
