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
    
    public partial class crmunidadcontrato
    {
        public int ID { get; set; }
        public int IDUnidad { get; set; }
        public string Tipo2 { get; set; }
        public string Modelo2 { get; set; }
        public string Ano2 { get; set; }
        public string Marca2 { get; set; }
        public string Serie2 { get; set; }
        public string Carroceria { get; set; }
        public string Color { get; set; }
        public string Placas { get; set; }
        public string ListaPrecios { get; set; }
        public Nullable<System.DateTime> FechaInicial { get; set; }
        public Nullable<System.DateTime> FechaFinal { get; set; }
        public Nullable<decimal> CargoFijo { get; set; }
        public Nullable<decimal> CargoxKM { get; set; }
        public Nullable<decimal> CargoxHrRefri { get; set; }
        public Nullable<decimal> CargoxTelemetria { get; set; }
        public Nullable<decimal> KMaRecorrer { get; set; }
        public Nullable<decimal> KMIncluidos { get; set; }
        public Nullable<decimal> HrRefriMes { get; set; }
        public Nullable<decimal> HrRefriIncluidos { get; set; }
        public string PeriodoFactura { get; set; }
        public string PeriodoTotal { get; set; }
        public string DiaFactura { get; set; }
        public string ModeloFact { get; set; }
        public string Seguro { get; set; }
        public Nullable<System.DateTime> FechaExpira { get; set; }
    }
}
