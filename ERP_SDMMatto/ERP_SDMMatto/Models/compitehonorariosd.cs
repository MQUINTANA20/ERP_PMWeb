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
    
    public partial class compitehonorariosd
    {
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public string ContactoD { get; set; }
        public string Servicio { get; set; }
        public string Horas { get; set; }
        public string Tamano { get; set; }
        public string Curso { get; set; }
        public Nullable<int> Numero { get; set; }
        public Nullable<System.DateTime> FechaPago { get; set; }
        public Nullable<decimal> ImportePago { get; set; }
    
        public virtual contacto contacto { get; set; }
    }
}