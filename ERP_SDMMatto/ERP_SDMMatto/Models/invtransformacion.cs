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
    
    public partial class invtransformacion
    {
        public int ID { get; set; }
        public int Empresa { get; set; }
        public string Mov { get; set; }
        public int Sucursal { get; set; }
        public string Folio { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public string Usuario { get; set; }
        public string Estatus { get; set; }
        public string Almacen { get; set; }
        public string WFEstado { get; set; }
        public string WFUsuario { get; set; }
        public Nullable<System.DateTime> FechaConclusion { get; set; }
        public Nullable<System.DateTime> FechaCancelacion { get; set; }
        public string Concepto { get; set; }
        public string Referencia { get; set; }
        public string Observaciones { get; set; }
        public string Proyecto { get; set; }
        public bool PorSucursal { get; set; }
        public Nullable<int> Ubicacion { get; set; }
    }
}
