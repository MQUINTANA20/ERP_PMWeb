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
    
    public partial class bcsaldo
    {
        public int Empresa { get; set; }
        public int ID { get; set; }
        public string Mov { get; set; }
        public string Contacto { get; set; }
        public Nullable<System.DateTime> Vencimiento { get; set; }
        public string Moneda { get; set; }
        public string Clase { get; set; }
        public Nullable<int> Factor { get; set; }
        public decimal Importe { get; set; }
        public Nullable<decimal> SaldoDeudor { get; set; }
        public Nullable<decimal> SaldoAcreedor { get; set; }
    }
}
