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
    
    public partial class manttoreftarea
    {
        public string MantenimientoTipo { get; set; }
        public string Servicio { get; set; }
        public int Numero { get; set; }
        public string Tarea { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public Nullable<decimal> CantidadUnidad { get; set; }
        public string Unidad { get; set; }
        public string Almacen { get; set; }
    }
}
