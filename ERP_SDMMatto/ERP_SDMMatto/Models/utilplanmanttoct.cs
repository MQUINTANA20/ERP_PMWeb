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
    
    public partial class utilplanmanttoct
    {
        public int IDInterno { get; set; }
        public int ID { get; set; }
        public string Contacto { get; set; }
        public string NombreCliente { get; set; }
        public string TipoContrato { get; set; }
        public string Equipo { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Nullable<int> Ano { get; set; }
        public string NoEconomico { get; set; }
        public string VIN { get; set; }
        public string TipoUnidad { get; set; }
        public string TipoMantenimiento { get; set; }
        public string Servicio { get; set; }
        public Nullable<System.DateTime> FechaProgramada { get; set; }
        public Nullable<int> KM { get; set; }
        public Nullable<int> IDMovAplica { get; set; }
        public Nullable<System.DateTime> UltimoMantto { get; set; }
        public Nullable<int> KMUltimoMantto { get; set; }
        public Nullable<decimal> KmMes { get; set; }
        public Nullable<decimal> KmMesProm { get; set; }
        public Nullable<bool> Seleccionar { get; set; }
        public Nullable<bool> Interno { get; set; }
    }
}
