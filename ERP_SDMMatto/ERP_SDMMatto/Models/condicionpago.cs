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
    
    public partial class condicionpago
    {
        public string Condicion { get; set; }
        public string Tipo { get; set; }
        public string TipoDias { get; set; }
        public Nullable<int> Numero { get; set; }
        public string DiasHabiles { get; set; }
        public bool PagareAuto { get; set; }
        public Nullable<int> PagareAutoNumero { get; set; }
        public string PagareAutoTipo { get; set; }
        public bool MesSiguiente { get; set; }
        public Nullable<int> ToleranciaDias { get; set; }
    }
}
