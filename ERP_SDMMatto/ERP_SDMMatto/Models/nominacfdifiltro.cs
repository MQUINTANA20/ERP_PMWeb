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
    
    public partial class nominacfdifiltro
    {
        public int ID { get; set; }
        public string Contacto { get; set; }
        public Nullable<bool> Procesar { get; set; }
        public string Version { get; set; }
        public string RegistroPatronal { get; set; }
        public string CURP { get; set; }
        public string TipoRegimen { get; set; }
        public string NumSeguridadSocial { get; set; }
        public Nullable<System.DateTime> FechaPago { get; set; }
        public Nullable<System.DateTime> FechaInicialPago { get; set; }
        public Nullable<System.DateTime> FechaFinalPago { get; set; }
        public Nullable<int> NumDiasPagados { get; set; }
        public string Departamento { get; set; }
        public string Clabe { get; set; }
        public string Banco { get; set; }
        public Nullable<System.DateTime> FechaInicioRelLaboral { get; set; }
        public string Antiguedad { get; set; }
        public string Puesto { get; set; }
        public string TipoContrato { get; set; }
        public string TipoJornada { get; set; }
        public string PeriodicidadPago { get; set; }
        public Nullable<decimal> SalarioBaseCotApor { get; set; }
        public string RiesgoPuesto { get; set; }
        public Nullable<decimal> SalarioDiarioIntegrado { get; set; }
        public Nullable<decimal> TotalPercepciones { get; set; }
        public Nullable<decimal> PercepcionesGravadas { get; set; }
        public Nullable<decimal> PercepcionesExentas { get; set; }
        public Nullable<decimal> TotalDeducciones { get; set; }
        public Nullable<decimal> DeduccionesGravadas { get; set; }
        public Nullable<decimal> DeduccionesExentas { get; set; }
        public Nullable<decimal> TotalIncapacidad { get; set; }
        public Nullable<decimal> TotalHorasExtra { get; set; }
        public bool Timbrado { get; set; }
        public string UUID { get; set; }
        public string Mensaje { get; set; }
    }
}
