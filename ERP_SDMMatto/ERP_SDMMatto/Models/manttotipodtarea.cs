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
    
    public partial class manttotipodtarea
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public manttotipodtarea()
        {
            this.manttotipodtareaarts = new HashSet<manttotipodtareaart>();
        }
    
        public string MantenimientoTipo { get; set; }
        public string Servicio { get; set; }
        public int Numero { get; set; }
        public string Tarea { get; set; }
        public string SubTarea { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> Horas { get; set; }
        public string ArticuloSE { get; set; }
        public string ListaPreciosT { get; set; }
        public Nullable<decimal> PrecioT { get; set; }
        public Nullable<decimal> DesgasteT { get; set; }
    
        public virtual manttotipod manttotipod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<manttotipodtareaart> manttotipodtareaarts { get; set; }
    }
}
