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
    
    public partial class movlista
    {
        public string Modulo { get; set; }
        public string Mov { get; set; }
        public Nullable<int> Numero { get; set; }
        public string Clase { get; set; }
        public bool WF { get; set; }
        public bool FE { get; set; }
        public string FETipo { get; set; }
        public string FEVersion { get; set; }
        public string ModuloOrigen { get; set; }
        public Nullable<bool> Vence { get; set; }
        public Nullable<int> VenceDias { get; set; }
        public Nullable<bool> ConFactura { get; set; }
        public bool ValidaOrigen { get; set; }
        public string Departamento { get; set; }
        public Nullable<bool> EsCampana { get; set; }
        public Nullable<bool> GeneraCT { get; set; }
        public Nullable<bool> ValidarXML { get; set; }
    }
}