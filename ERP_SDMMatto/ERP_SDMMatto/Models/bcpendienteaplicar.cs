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
    
    public partial class bcpendienteaplicar
    {
        public int pid { get; set; }
        public int ID { get; set; }
        public string Mov { get; set; }
        public string Folio { get; set; }
        public string Referencia { get; set; }
        public Nullable<System.DateTime> Vencimiento { get; set; }
        public string Clase { get; set; }
        public int Factor { get; set; }
        public decimal Importe { get; set; }
        public decimal Saldo { get; set; }
        public Nullable<decimal> ImporteAplicar { get; set; }
        public Nullable<decimal> ImporteDeudor { get; set; }
        public Nullable<decimal> ImporteAcreedor { get; set; }
        public Nullable<decimal> DifDeudor { get; set; }
        public Nullable<decimal> DifAcreedor { get; set; }
        public Nullable<decimal> Dif { get; set; }
        public Nullable<int> Sucursal { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public string Observaciones { get; set; }
        public string WFEstado { get; set; }
    }
}