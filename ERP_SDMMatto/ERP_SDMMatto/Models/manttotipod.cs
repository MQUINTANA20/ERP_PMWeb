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
    
    public partial class manttotipod
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public manttotipod()
        {
            this.manttotipodtareas = new HashSet<manttotipodtarea>();
        }
    
        public string MantenimientoTipo { get; set; }
        public string Servicio { get; set; }
        public int Desgaste { get; set; }
        public int Tiempo { get; set; }
        public string Unidad { get; set; }
        public int Dias { get; set; }
        public string Tipo { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> FrecuenciaT { get; set; }
        public string UnidadT { get; set; }
        public string GrupoT { get; set; }
        public string CategoriaT { get; set; }
        public string PrioridadT { get; set; }
        public Nullable<int> HoraT { get; set; }
        public Nullable<int> MinutoT { get; set; }
        public bool RequiereParoT { get; set; }
        public Nullable<int> DiasParoT { get; set; }
        public string TipoUnidadD { get; set; }
        public string ArticuloSE { get; set; }
    
        public virtual manttotipo manttotipo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<manttotipodtarea> manttotipodtareas { get; set; }
    }
}