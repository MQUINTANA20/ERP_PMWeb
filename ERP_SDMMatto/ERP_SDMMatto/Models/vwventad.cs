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
    
    public partial class vwventad
    {
        public int ID { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public string PoseeCore { get; set; }
        public string ArticuloCore { get; set; }
        public string ArticuloCoreDescripcion { get; set; }
        public string Linea { get; set; }
        public string SubLinea { get; set; }
        public string Marca { get; set; }
        public string Departamento { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }
        public decimal CostoPesos { get; set; }
        public Nullable<decimal> CantidadUnidad { get; set; }
        public string Unidad { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> ImporteD { get; set; }
        public decimal ImporteDPesos { get; set; }
        public decimal Utilidad { get; set; }
        public Nullable<decimal> PorcMB { get; set; }
    }
}
