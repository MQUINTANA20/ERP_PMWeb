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
    
    public partial class exceledoctaprev
    {
        public int ID { get; set; }
        public string ECuentaBanco { get; set; }
        public string EDescripcion { get; set; }
        public string EReferencia { get; set; }
        public Nullable<System.DateTime> EFecha { get; set; }
        public Nullable<decimal> ECargo { get; set; }
        public Nullable<decimal> EAbono { get; set; }
        public string EEstatusConc { get; set; }
        public Nullable<bool> EConciliado { get; set; }
    }
}
