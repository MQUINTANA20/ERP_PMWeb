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
    
    public partial class invplanarticulouso
    {
        public int Empresa { get; set; }
        public string Almacen { get; set; }
        public string Articulo { get; set; }
        public int Ejercicio { get; set; }
        public int Periodo { get; set; }
        public Nullable<decimal> Uso { get; set; }
        public Nullable<decimal> UsoSuavizado { get; set; }
        public bool UsoSuavizadoManual { get; set; }
        public Nullable<int> Hits { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public string RankHits { get; set; }
        public Nullable<float> PorcHits { get; set; }
        public string RankCosto { get; set; }
        public Nullable<float> PorcCosto { get; set; }
        public string RankUtilidad { get; set; }
        public Nullable<float> PorcUtilidad { get; set; }
    }
}