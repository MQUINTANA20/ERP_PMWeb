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
    
    public partial class cgordengastoi
    {
        public int ID { get; set; }
        public int Empresa { get; set; }
        public string Mov { get; set; }
        public string Usuario { get; set; }
        public int Sucursal { get; set; }
        public string Moneda { get; set; }
        public decimal TipoCambio { get; set; }
        public string Referencia { get; set; }
        public string Observaciones { get; set; }
        public string Concepto { get; set; }
        public string Contacto { get; set; }
        public string CondicionPago { get; set; }
        public Nullable<System.DateTime> Vencimiento { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public string OrigenModulo { get; set; }
        public Nullable<int> OrigenID { get; set; }
        public string CentroCostos { get; set; }
        public string ZonaImpuesto { get; set; }
    }
}
