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
    
    public partial class crmcampana
    {
        public int ID { get; set; }
        public string NoCampana { get; set; }
        public string Descripcion { get; set; }
        public string CodigoSRT { get; set; }
        public string Proveedor { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public Nullable<bool> TieneGarantia { get; set; }
        public string TipoGarantia { get; set; }
        public string MovimientoGen { get; set; }
        public Nullable<System.DateTime> FechaProgramada { get; set; }
    }
}
