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
    
    public partial class articuloposicion
    {
        public int Empresa { get; set; }
        public string Almacen { get; set; }
        public string Articulo { get; set; }
        public Nullable<decimal> Minimo { get; set; }
        public Nullable<decimal> PuntoReorden { get; set; }
        public Nullable<decimal> Maximo { get; set; }
        public string Pasillo { get; set; }
        public string Fila { get; set; }
        public string Nivel { get; set; }
        public string Posicion { get; set; }
        public Nullable<decimal> TiempoInv { get; set; }
        public string UnidadTiempoInv { get; set; }
        public Nullable<bool> Stock { get; set; }
        public string RankingHit { get; set; }
        public string RankingCosto { get; set; }
        public string Clasificacion { get; set; }
        public string TipDem { get; set; }
        public string TipoDemanda { get; set; }
        public Nullable<bool> InfantCare { get; set; }
        public Nullable<bool> Critico { get; set; }
        public Nullable<int> TiempoEntrega { get; set; }
        public Nullable<System.DateTime> FechaIntroduccion { get; set; }
        public Nullable<bool> ReposicionCongelada { get; set; }
        public Nullable<System.DateTime> ReposicionFechaDeshielo { get; set; }
        public Nullable<decimal> StockSeguridad { get; set; }
        public Nullable<decimal> PuntoLinea { get; set; }
        public Nullable<decimal> COE { get; set; }
        public Nullable<int> SOQ { get; set; }
        public Nullable<bool> Estacional { get; set; }
        public Nullable<int> Formula { get; set; }
        public Nullable<decimal> MinimoD { get; set; }
        public Nullable<decimal> MaximoD { get; set; }
        public Nullable<int> PeriodoPrueba { get; set; }
        public Nullable<int> VentaProyectada { get; set; }
    }
}
