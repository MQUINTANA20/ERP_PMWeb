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
    
    public partial class articulocostocapaauxiliar
    {
        public int ID { get; set; }
        public int Empresa { get; set; }
        public string Articulo { get; set; }
        public string Almacen { get; set; }
        public string Tipo { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IDCapa { get; set; }
        public Nullable<decimal> Cargo { get; set; }
        public Nullable<decimal> Abono { get; set; }
        public string Modulo { get; set; }
        public int ModuloID { get; set; }
        public string Mov { get; set; }
        public string Folio { get; set; }
        public Nullable<bool> Cancelado { get; set; }
    }
}
