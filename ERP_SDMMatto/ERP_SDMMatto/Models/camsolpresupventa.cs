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
    
    public partial class camsolpresupventa
    {
        public int ID { get; set; }
        public string NombrePresupuesto { get; set; }
        public int Sucursal { get; set; }
        public int Ejercicio { get; set; }
        public string Agente { get; set; }
        public bool Utilizado { get; set; }
    }
}
