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
    
    public partial class manttopland
    {
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public string Equipo { get; set; }
        public string TipoMantto { get; set; }
        public string Servicio { get; set; }
        public Nullable<System.DateTime> UltimoMantto { get; set; }
        public bool Excluir { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Desgaste { get; set; }
    }
}
