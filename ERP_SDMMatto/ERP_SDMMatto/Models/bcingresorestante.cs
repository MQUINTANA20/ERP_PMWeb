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
    
    public partial class bcingresorestante
    {
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public decimal ImporteD { get; set; }
        public string FormaPagoCobro { get; set; }
        public string Referencia { get; set; }
        public string Moneda { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal ImporteAplica { get; set; }
    }
}
