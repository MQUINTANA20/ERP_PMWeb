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
    
    public partial class incidd
    {
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public string Contacto { get; set; }
        public string Referencia { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public string Hora { get; set; }
        public Nullable<decimal> CantidadPendiente { get; set; }
        public Nullable<decimal> Saldo { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string RegistroTipo { get; set; }
    
        public virtual contacto contacto1 { get; set; }
    }
}
