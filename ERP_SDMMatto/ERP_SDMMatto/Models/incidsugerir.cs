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
    
    public partial class incidsugerir
    {
        public int PID { get; set; }
        public int ID { get; set; }
        public int IDInterno { get; set; }
        public string Personal { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Tipo { get; set; }
        public Nullable<int> Minutos { get; set; }
        public Nullable<int> Horas { get; set; }
        public Nullable<decimal> Dias { get; set; }
        public bool Excluir { get; set; }
        public string Accion { get; set; }
    }
}
