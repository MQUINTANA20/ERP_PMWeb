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
    
    public partial class ubicacionmov
    {
        public int ID { get; set; }
        public string Modulo { get; set; }
        public int RenglonID { get; set; }
        public string Articulo { get; set; }
        public int Ubicacion { get; set; }
        public System.DateTime FechaD { get; set; }
        public System.DateTime FechaA { get; set; }
        public string HoraD { get; set; }
        public string HoraA { get; set; }
        public int Cantidad { get; set; }
    
        public virtual ubicacion ubicacion1 { get; set; }
    }
}