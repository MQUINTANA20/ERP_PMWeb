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
    
    public partial class nominatablatoped
    {
        public string Tipo { get; set; }
        public decimal Hasta { get; set; }
        public Nullable<decimal> Valor { get; set; }
    
        public virtual nominatablatope nominatablatope { get; set; }
    }
}
