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
    
    public partial class bancosucursal
    {
        public string Banco { get; set; }
        public string Sucursal { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }
        public string Poblacion { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }
        public string Telefonos { get; set; }
        public string Contacto1 { get; set; }
        public string Contacto2 { get; set; }
    
        public virtual banco banco1 { get; set; }
    }
}
