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
    
    public partial class camsolcostocarroceria
    {
        public string TipoUnidad { get; set; }
        public string Proveedor { get; set; }
        public string Carroceria { get; set; }
        public string Moneda { get; set; }
        public Nullable<decimal> DescuentoAL { get; set; }
        public Nullable<decimal> CostoAct { get; set; }
        public Nullable<decimal> CostoAnt { get; set; }
        public string Estatus { get; set; }
        public string AccesoriosDefault { get; set; }
        public int IDInterno { get; set; }
        public string Modelo { get; set; }
    }
}
