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
    
    public partial class objetivocompraanc
    {
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public string Mov { get; set; }
        public string Moneda { get; set; }
        public decimal TipoCambio { get; set; }
        public string Concepto { get; set; }
        public string Referencia { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public Nullable<decimal> Impuestos { get; set; }
        public string RFC { get; set; }
        public string UUID { get; set; }
        public string SerieConsecutivo { get; set; }
        public string FechaTimbrado { get; set; }
        public string TotalXML { get; set; }
        public string MonedaXML { get; set; }
    }
}
