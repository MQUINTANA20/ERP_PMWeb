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
    
    public partial class chequesbc
    {
        public int Empresa { get; set; }
        public string CuentaBanco { get; set; }
        public string Movimiento { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public string Contacto { get; set; }
        public string NombreContacto { get; set; }
    }
}