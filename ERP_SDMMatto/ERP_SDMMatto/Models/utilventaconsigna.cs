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
    
    public partial class utilventaconsigna
    {
        public int PID { get; set; }
        public int IDInterno { get; set; }
        public int SucursalCliente { get; set; }
        public string Articulo { get; set; }
        public Nullable<decimal> CantidadInicial { get; set; }
        public Nullable<decimal> InventarioConsigna { get; set; }
        public string Unidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Enviados { get; set; }
        public Nullable<decimal> Facturado { get; set; }
        public Nullable<decimal> RotacionPromedio { get; set; }
    }
}
