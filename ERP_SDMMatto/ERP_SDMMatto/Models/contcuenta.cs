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
    
    public partial class contcuenta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contcuenta()
        {
            this.contactonominacuentas = new HashSet<contactonominacuenta>();
            this.contds = new HashSet<contd>();
        }
    
        public string Cuenta { get; set; }
        public string Descripcion { get; set; }
        public string Nivel { get; set; }
        public string CuentaPadre { get; set; }
        public bool Acumulativa { get; set; }
        public bool Acreedora { get; set; }
        public bool Utilizado { get; set; }
        public string Estatus { get; set; }
        public string Grupo { get; set; }
        public string CodigoAgrupador { get; set; }
        public string Naturaleza { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contactonominacuenta> contactonominacuentas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contd> contds { get; set; }
    }
}
