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
    
    public partial class ventadpretotal
    {
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public string Articulo { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public decimal Precio { get; set; }
        public Nullable<decimal> DescLinea { get; set; }
        public decimal Impuesto1 { get; set; }
        public Nullable<decimal> Impuesto2 { get; set; }
        public Nullable<decimal> RetencionISR { get; set; }
        public Nullable<decimal> RetencionIVA { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<int> AplicaID { get; set; }
        public Nullable<decimal> CantidadPendiente { get; set; }
        public Nullable<decimal> ImporteD { get; set; }
        public Nullable<decimal> Impuesto1ImporteD { get; set; }
        public Nullable<decimal> Impuesto2ImporteD { get; set; }
        public Nullable<decimal> RetIVAImporteD { get; set; }
        public Nullable<decimal> RetISRImporteD { get; set; }
        public Nullable<int> KitRenglonID { get; set; }
        public Nullable<int> RenglonControl { get; set; }
        public string CodigoBarras { get; set; }
        public Nullable<decimal> CantidadA { get; set; }
        public Nullable<decimal> CantidadUnidad { get; set; }
        public string Unidad { get; set; }
        public float Factor { get; set; }
        public Nullable<int> Bultos { get; set; }
        public string Modelo { get; set; }
        public string Renglon { get; set; }
        public string Columna { get; set; }
        public string PropiedadRenglon { get; set; }
        public string PropiedadColumna { get; set; }
        public Nullable<decimal> CantidadEmbarcada { get; set; }
        public Nullable<decimal> ImpuestoSH { get; set; }
        public Nullable<decimal> ImpuestoSHImporteD { get; set; }
        public Nullable<decimal> CantidadReservada { get; set; }
        public string ListaPreciosD { get; set; }
        public string AlmacenD { get; set; }
        public Nullable<decimal> ComisionPorcD { get; set; }
        public Nullable<decimal> ComisionImporteD { get; set; }
        public string ArticuloCore { get; set; }
        public Nullable<int> VentaRenglonID { get; set; }
        public Nullable<int> VentaID { get; set; }
        public string ObservacionesD { get; set; }
        public Nullable<decimal> PrecioRX { get; set; }
        public Nullable<decimal> PrecioCore { get; set; }
        public string Descripcion2 { get; set; }
        public string ListaPSAplica { get; set; }
        public string NegociacionPSAplica { get; set; }
        public string ListaPSAplicaT { get; set; }
        public string NegociacionPSAplicaT { get; set; }
        public Nullable<decimal> DescImporte { get; set; }
        public Nullable<decimal> Rentabilidad { get; set; }
        public Nullable<bool> PlanExcluirD { get; set; }
        public string UbicacionD { get; set; }
        public string NoParteArticulo { get; set; }
        public string ArticuloVin { get; set; }
        public string VIN { get; set; }
        public Nullable<int> Posicion { get; set; }
    }
}