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
    
    public partial class contactobeneficiario
    {
        public int ID { get; set; }
        public string Contacto { get; set; }
        public string Beneficiario { get; set; }
        public string RelacionTipo { get; set; }
        public decimal Porcentaje { get; set; }
    
        public virtual contactopersonal contactopersonal { get; set; }
    }
}
