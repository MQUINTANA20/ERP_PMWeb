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
    
    public partial class afcarga
    {
        public int ID { get; set; }
        public string ArticuloCarga { get; set; }
        public string Serie { get; set; }
        public decimal AdquisicionImporte { get; set; }
        public System.DateTime AdquisicionFecha { get; set; }
        public string Tipo { get; set; }
        public int MesesVidaUtil { get; set; }
        public Nullable<int> DepreciacionMeses { get; set; }
        public Nullable<decimal> DepreciacionImporte { get; set; }
        public string Descripcion2SL { get; set; }
    
        public virtual articulo articulo { get; set; }
    }
}
