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
    
    public partial class pcd
    {
        public int ID { get; set; }
        public string Articulo { get; set; }
        public Nullable<decimal> Nuevo { get; set; }
        public Nullable<decimal> Anterior { get; set; }
        public string MonedaActual { get; set; }
        public string MonedaNueva { get; set; }
        public Nullable<bool> RetornoActual { get; set; }
        public Nullable<bool> RetornoNuevo { get; set; }
        public string ObservacionesD { get; set; }
        public string NoParteProv { get; set; }
    
        public virtual articulo articulo1 { get; set; }
    }
}