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
    
    public partial class cmscamsol
    {
        public string CodigoCMS { get; set; }
        public string Descripcion { get; set; }
        public string TipoComision { get; set; }
        public string Periodo { get; set; }
        public Nullable<bool> ConciliacionBancaria { get; set; }
        public Nullable<decimal> ImporteComisionCB { get; set; }
        public Nullable<bool> ComisionVenta { get; set; }
        public Nullable<bool> ComisionxVencimiento { get; set; }
        public Nullable<bool> BonoxPresupVenta { get; set; }
        public Nullable<bool> ComisionCRM { get; set; }
        public Nullable<bool> ComisionContrato { get; set; }
        public Nullable<bool> ComisionR2R { get; set; }
        public Nullable<bool> ComisionCalidad { get; set; }
        public Nullable<bool> ComisionMantenimiento { get; set; }
        public Nullable<bool> UsoFlota { get; set; }
        public Nullable<int> MesesXFacturacion { get; set; }
        public Nullable<int> MesesxInactividad { get; set; }
        public string Puesto { get; set; }
    }
}
