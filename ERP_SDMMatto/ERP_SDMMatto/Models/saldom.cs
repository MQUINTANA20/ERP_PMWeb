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
    
    public partial class saldom
    {
        public int Empresa { get; set; }
        public string Almacen { get; set; }
        public string Modulo { get; set; }
        public string Contacto { get; set; }
        public string Moneda { get; set; }
        public string Articulo { get; set; }
        public Nullable<decimal> Saldo { get; set; }
        public Nullable<decimal> SaldoU { get; set; }
    }
}