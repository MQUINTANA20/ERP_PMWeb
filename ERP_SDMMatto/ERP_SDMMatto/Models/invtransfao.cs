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
    
    public partial class invtransfao
    {
        public int PID { get; set; }
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public Nullable<bool> Seleccionar { get; set; }
        public string Mov { get; set; }
        public string Folio { get; set; }
        public string Almacen { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public string Articulo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> CantidadUnidad { get; set; }
        public string Unidad { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> Avanzar { get; set; }
        public string AlmacenDO { get; set; }
    }
}
