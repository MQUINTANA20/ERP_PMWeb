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
    
    public partial class conciliamanualpuente
    {
        public int ID { get; set; }
        public string CuentaBanco { get; set; }
        public string Mov { get; set; }
        public string Referencia { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> Cargo { get; set; }
        public Nullable<decimal> Abono { get; set; }
        public string EstatusConc { get; set; }
        public Nullable<bool> Conciliar { get; set; }
        public string CuentaBancoDestino { get; set; }
        public Nullable<decimal> Importe { get; set; }
    }
}
