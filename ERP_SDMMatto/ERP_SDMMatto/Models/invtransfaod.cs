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
    
    public partial class invtransfaod
    {
        public int PID { get; set; }
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public Nullable<bool> SeleccionarD { get; set; }
        public string MovD { get; set; }
        public string FolioD { get; set; }
        public string AlmacenD { get; set; }
        public Nullable<System.DateTime> FechaEmisionD { get; set; }
        public string ArticuloD { get; set; }
        public string DescripcionD { get; set; }
        public Nullable<decimal> CantidadUnidadD { get; set; }
        public string UnidadD { get; set; }
        public Nullable<decimal> CantidadD { get; set; }
        public Nullable<decimal> AvanzarD { get; set; }
        public string AlmacenDD { get; set; }
    }
}
