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
    
    public partial class cmsplantilla
    {
        public string CodigoCMS { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> AplicaIVA { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<decimal> Retencion { get; set; }
        public Nullable<bool> ComisionGeneral { get; set; }
        public Nullable<decimal> PorcentajeG { get; set; }
        public Nullable<bool> ComisionGrupo { get; set; }
        public Nullable<bool> ComisionCategoria { get; set; }
        public Nullable<bool> ComisionLinea { get; set; }
        public Nullable<bool> ComisionFamilia { get; set; }
        public Nullable<bool> ComisionArticulo { get; set; }
        public Nullable<bool> ComisionMov { get; set; }
        public Nullable<bool> ComisionCliente { get; set; }
    }
}
