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
    
    public partial class grupoconfd
    {
        public string Grupo { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public bool Valor { get; set; }
        public string Descripcion { get; set; }
        public string Clase { get; set; }
        public bool Editar { get; set; }
    
        public virtual grupoconf grupoconf { get; set; }
    }
}