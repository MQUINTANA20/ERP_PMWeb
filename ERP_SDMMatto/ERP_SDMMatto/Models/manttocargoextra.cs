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
    
    public partial class manttocargoextra
    {
        public int ID { get; set; }
        public string CodigoBarras { get; set; }
        public string ArticuloCEx { get; set; }
        public Nullable<decimal> CantidadUnidad { get; set; }
        public string Unidad { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public string ListaPrecios { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<bool> MaterialFaltante { get; set; }
        public int RenglonID { get; set; }
        public bool AvanzarCE { get; set; }
        public Nullable<bool> AplicadoCE { get; set; }
        public string Descripcion2 { get; set; }
        public Nullable<bool> TieneGarantiaC { get; set; }
        public string TipoGarantiaC { get; set; }
        public Nullable<bool> GarantiaAplicadaC { get; set; }
        public string ProveedorCE { get; set; }
        public Nullable<bool> ActivarCE { get; set; }
        public string ListaPSAplica { get; set; }
        public string ListaPSAplicaT { get; set; }
    }
}
