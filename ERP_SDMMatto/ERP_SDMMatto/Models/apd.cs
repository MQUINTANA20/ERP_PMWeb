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
    
    public partial class apd
    {
        public int ID { get; set; }
        public string Contacto { get; set; }
        public string JefeInmediato { get; set; }
        public Nullable<int> PersonalSucursal { get; set; }
        public Nullable<System.DateTime> FechaAntiguedad { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
        public string Departamento { get; set; }
        public string Puesto { get; set; }
        public string MovNomina { get; set; }
        public string ZonaEconomica { get; set; }
        public string Periodo { get; set; }
        public string Jornada { get; set; }
        public string ContratoTipo { get; set; }
        public Nullable<System.DateTime> ContratoVencimiento { get; set; }
        public Nullable<decimal> SueldoDiario { get; set; }
        public Nullable<decimal> SDI { get; set; }
        public string TipoDias { get; set; }
        public string CentroCostos { get; set; }
        public string Sindicalizado { get; set; }
    
        public virtual contacto contacto1 { get; set; }
    }
}
