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
    
    public partial class cubicajemov
    {
        public int ID { get; set; }
        public string Modulo { get; set; }
        public int RenglonID { get; set; }
        public string Articulo { get; set; }
        public int IDInterno { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public decimal Alto { get; set; }
        public decimal Largo { get; set; }
        public decimal Ancho { get; set; }
        public decimal Cubicaje { get; set; }
    }
}