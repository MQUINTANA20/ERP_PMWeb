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
    
    public partial class prodretrocesoconsumo
    {
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public string Material { get; set; }
        public Nullable<decimal> MaterialCantidad { get; set; }
        public Nullable<decimal> MaterialCantidadUnidad { get; set; }
        public string MaterialUnidad { get; set; }
        public string Almacen { get; set; }
        public string AlmacenDestino { get; set; }
    }
}
