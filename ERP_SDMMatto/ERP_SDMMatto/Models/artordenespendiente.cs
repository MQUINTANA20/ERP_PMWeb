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
    
    public partial class artordenespendiente
    {
        public int Empresa { get; set; }
        public int ID { get; set; }
        public string Mov { get; set; }
        public string Folio { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public string Almacen { get; set; }
        public string Articulo { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public decimal Costo { get; set; }
        public Nullable<decimal> ImporteD { get; set; }
        public Nullable<decimal> Impuesto1ImporteD { get; set; }
        public Nullable<decimal> Impuesto2ImporteD { get; set; }
        public Nullable<decimal> RetIVAImporteD { get; set; }
        public Nullable<decimal> RetISRImporteD { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> CantidadPendiente { get; set; }
    }
}