//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_SDMMatto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class impuestocuota
    {
        public int ID { get; set; }
        public string RangoFijo { get; set; }
        public Nullable<decimal> ValorMinimo { get; set; }
        public decimal ValorMaximo { get; set; }
        public string Impuesto { get; set; }
        public string Factor { get; set; }
        public bool Traslado { get; set; }
        public bool Retencion { get; set; }
        public System.DateTime VigenciaInicio { get; set; }
        public Nullable<System.DateTime> VigenciaFin { get; set; }
    }
}