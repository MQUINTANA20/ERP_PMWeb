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
    
    public partial class objetivocomprad
    {
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public string TipoAgrupador { get; set; }
        public string Agrupador { get; set; }
        public string Mes { get; set; }
        public Nullable<decimal> ObjetivoCompra { get; set; }
        public string Moneda { get; set; }
        public Nullable<decimal> TipoCambio { get; set; }
        public Nullable<decimal> ObjetivoCompraMXN { get; set; }
        public Nullable<decimal> CompraReal { get; set; }
        public Nullable<decimal> PorcAlcanzado { get; set; }
        public string IncentivoTipo { get; set; }
        public bool IncentivoGanado { get; set; }
        public string IncentivoEstatus { get; set; }
        public Nullable<decimal> OrdenCompra { get; set; }
        public Nullable<decimal> PorcOrdenCompra { get; set; }
        public Nullable<decimal> FacturaProveedor { get; set; }
        public Nullable<decimal> PorcFacturaProveedor { get; set; }
        public Nullable<int> IDBC { get; set; }
        public string AplicaMovBC { get; set; }
        public Nullable<decimal> SaldoMovBC { get; set; }
        public Nullable<decimal> DescuentoAplicado { get; set; }
    }
}
