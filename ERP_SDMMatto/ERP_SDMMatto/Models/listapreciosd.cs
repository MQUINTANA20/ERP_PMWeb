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
    
    public partial class listapreciosd
    {
        public string Lista { get; set; }
        public string Articulo { get; set; }
        public decimal Precio { get; set; }
        public Nullable<System.DateTime> UltimoCambio { get; set; }
    
        public virtual listaprecio listaprecio { get; set; }
    }
}