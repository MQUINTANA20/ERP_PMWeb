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
    
    public partial class movautorizarusuariopartar
    {
        public int IDInterno { get; set; }
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public bool AutorizarRechazarAR { get; set; }
        public bool NuevoRenglonAR { get; set; }
        public string ArticuloAR { get; set; }
        public Nullable<decimal> CantidadUnidadAR { get; set; }
        public string UnidadAR { get; set; }
        public Nullable<decimal> CantidadAR { get; set; }
        public Nullable<decimal> CostoAR { get; set; }
        public Nullable<decimal> PrecioAR { get; set; }
        public Nullable<decimal> CantidadPendienteAR { get; set; }
        public string CentroCostosDAR { get; set; }
        public Nullable<decimal> DescLineaAR { get; set; }
        public Nullable<float> FactorAR { get; set; }
        public Nullable<decimal> ImporteDAR { get; set; }
        public Nullable<decimal> ImpuestoR { get; set; }
        public Nullable<decimal> Impuesto1ImporteDAR { get; set; }
        public Nullable<decimal> Impuesto2AR { get; set; }
        public Nullable<decimal> Impuesto2ImporteDAR { get; set; }
        public Nullable<decimal> ImpuestoSHAR { get; set; }
        public Nullable<decimal> ImpuestoSHImporteDAR { get; set; }
        public Nullable<decimal> RetencionIVAAR { get; set; }
        public Nullable<decimal> RetIVAImporteDAR { get; set; }
        public Nullable<decimal> RetencionISRAR { get; set; }
        public Nullable<decimal> RetISRImporteDAR { get; set; }
        public Nullable<decimal> RetencionCedularAR { get; set; }
        public Nullable<decimal> RetCedularImporteDAR { get; set; }
        public Nullable<decimal> DeduciblePorcentajeAR { get; set; }
        public Nullable<decimal> DeducibleImporteAR { get; set; }
        public string ContactoDAR { get; set; }
        public string ReferenciaDAR { get; set; }
        public Nullable<decimal> CantidadUnidadOrigAR { get; set; }
        public string UnidadOrigAR { get; set; }
        public Nullable<decimal> CantidadOrigAR { get; set; }
        public Nullable<decimal> CostoOrigAR { get; set; }
        public Nullable<decimal> PrecioOrigAR { get; set; }
        public Nullable<decimal> DescLineaOrigAR { get; set; }
        public string CentroCostosDOrigAR { get; set; }
        public string EstadoAutorizacionAR { get; set; }
        public Nullable<System.DateTime> FechaAutorizadoRechazadoAR { get; set; }
        public string UsuarioAutRecAR { get; set; }
        public string UsuarioSolicitoAR { get; set; }
        public string ArticuloCoreAR { get; set; }
        public Nullable<decimal> CostoCoreAR { get; set; }
        public Nullable<decimal> CostoRXAR { get; set; }
    }
}