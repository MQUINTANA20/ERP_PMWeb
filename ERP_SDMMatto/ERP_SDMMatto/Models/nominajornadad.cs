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
    
    public partial class nominajornadad
    {
        public string Jornada { get; set; }
        public string Dia { get; set; }
        public string InicioLab { get; set; }
        public string InicioCom { get; set; }
        public string FinCom { get; set; }
        public string FinLab { get; set; }
    
        public virtual nominajornada nominajornada { get; set; }
    }
}