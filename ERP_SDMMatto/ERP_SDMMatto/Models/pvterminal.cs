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
    
    public partial class pvterminal
    {
        public int Terminal { get; set; }
        public string MacAdress { get; set; }
        public Nullable<int> Empresa { get; set; }
        public Nullable<int> Sucursal { get; set; }
        public string Caja { get; set; }
        public string MovOmision { get; set; }
        public bool Comanda { get; set; }
        public Nullable<int> ComandaUbicacion { get; set; }
        public bool ComandaControlMesa { get; set; }
    }
}
