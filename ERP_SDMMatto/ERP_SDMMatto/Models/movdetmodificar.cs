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
    
    public partial class movdetmodificar
    {
        public int Empresa { get; set; }
        public string Modulo { get; set; }
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public string Articulo { get; set; }
        public Nullable<decimal> CantidadUnidad { get; set; }
        public string Unidad { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> CantidadPendiente { get; set; }
        public string CentroCostosD { get; set; }
        public Nullable<decimal> DescLinea { get; set; }
        public Nullable<float> Factor { get; set; }
        public Nullable<decimal> Impuesto1 { get; set; }
        public Nullable<decimal> Impuesto2 { get; set; }
        public Nullable<decimal> ImpuestoSH { get; set; }
        public Nullable<decimal> RetencionIVA { get; set; }
        public Nullable<decimal> RetencionISR { get; set; }
        public Nullable<decimal> RetencionCedular { get; set; }
        public Nullable<decimal> DeduciblePorcentaje { get; set; }
        public string ContactoD { get; set; }
        public string ReferenciaD { get; set; }
        public Nullable<decimal> CantidadUnidadOrig { get; set; }
        public string UnidadOrig { get; set; }
        public Nullable<decimal> CantidadOrig { get; set; }
        public Nullable<decimal> CostoOrig { get; set; }
        public Nullable<decimal> PrecioOrig { get; set; }
        public Nullable<decimal> DescLineaOrig { get; set; }
        public string CentroCostosDOrig { get; set; }
        public string ArticuloCore { get; set; }
        public Nullable<decimal> CostoCore { get; set; }
        public Nullable<decimal> CostoRX { get; set; }
        public Nullable<decimal> DescImporte { get; set; }
        public Nullable<decimal> DescImporteOrig { get; set; }
    }
}