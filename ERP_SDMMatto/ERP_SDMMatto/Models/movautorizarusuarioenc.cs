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
    
    public partial class movautorizarusuarioenc
    {
        public int IDInterno { get; set; }
        public Nullable<int> IDAutorizar { get; set; }
        public int Empresa { get; set; }
        public string Modulo { get; set; }
        public string Clase { get; set; }
        public int ID { get; set; }
        public string Mov { get; set; }
        public string Folio { get; set; }
        public string Estatus { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public Nullable<decimal> Impuestos { get; set; }
        public Nullable<decimal> Impuestos2 { get; set; }
        public Nullable<decimal> ImpuestosSH { get; set; }
        public Nullable<decimal> RetIVAImporte { get; set; }
        public Nullable<decimal> RetISRImporte { get; set; }
        public Nullable<decimal> RetCedularImporte { get; set; }
        public Nullable<decimal> TotalMov { get; set; }
        public string Usuario { get; set; }
        public string AsignadoA { get; set; }
        public string Mensaje { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
        public string WFEstado { get; set; }
        public string Contacto { get; set; }
        public Nullable<decimal> MB { get; set; }
    }
}
