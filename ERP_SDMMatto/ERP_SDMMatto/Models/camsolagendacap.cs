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
    
    public partial class camsolagendacap
    {
        public int PID { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public string HoraInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public string HoraFin { get; set; }
        public string Contacto { get; set; }
        public string ContactoCliente { get; set; }
        public string Asunto { get; set; }
        public string Observaciones { get; set; }
        public string Estatus { get; set; }
        public string Agente { get; set; }
        public string Resultado { get; set; }
        public Nullable<bool> Efectiva { get; set; }
        public string Oportunidad { get; set; }
        public string GrupoContrato { get; set; }
        public string Objetivo { get; set; }
        public string NombreContacto { get; set; }
    }
}
