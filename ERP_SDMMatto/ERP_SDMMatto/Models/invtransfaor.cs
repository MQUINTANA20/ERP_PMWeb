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
    
    public partial class invtransfaor
    {
        public int PID { get; set; }
        public int ID { get; set; }
        public int RenglonID { get; set; }
        public Nullable<bool> SeleccionarR { get; set; }
        public string MovR { get; set; }
        public string FolioR { get; set; }
        public string AlmacenR { get; set; }
        public Nullable<System.DateTime> FechaEmisionR { get; set; }
        public string ArticuloR { get; set; }
        public string DescripcionR { get; set; }
        public Nullable<decimal> CantidadUnidadR { get; set; }
        public string UnidadR { get; set; }
        public Nullable<decimal> CantidadR { get; set; }
        public Nullable<decimal> AvanzarR { get; set; }
        public string AlmacenDR { get; set; }
    }
}