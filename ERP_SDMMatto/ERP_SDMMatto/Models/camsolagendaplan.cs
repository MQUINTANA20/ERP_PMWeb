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
    
    public partial class camsolagendaplan
    {
        public int PID { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public string HoraInicio { get; set; }
        public int HorasEntreCitas { get; set; }
        public string HoraFin { get; set; }
        public string Asunto { get; set; }
        public string GrupoContrato { get; set; }
        public string Objetivo { get; set; }
        public string GrupoCliente { get; set; }
        public Nullable<int> MesesInactivo { get; set; }
        public Nullable<int> CitasxDia { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public string Departamento { get; set; }
    }
}
