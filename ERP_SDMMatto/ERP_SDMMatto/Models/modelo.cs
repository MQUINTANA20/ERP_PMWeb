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
    
    public partial class modelo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public modelo()
        {
            this.modeloarticuloes = new HashSet<modeloarticulo>();
        }
    
        public string Modelo1 { get; set; }
        public string Descripcion { get; set; }
        public string Renglon { get; set; }
        public string Columna { get; set; }
    
        public virtual dimension dimension { get; set; }
        public virtual dimension dimension1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<modeloarticulo> modeloarticuloes { get; set; }
    }
}
