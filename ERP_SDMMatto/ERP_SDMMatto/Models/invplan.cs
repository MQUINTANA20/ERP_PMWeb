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
    
    public partial class invplan
    {
        public int ID { get; set; }
        public int Empresa { get; set; }
        public int Sucursal { get; set; }
        public string Usuario { get; set; }
        public string Mov { get; set; }
        public string Folio { get; set; }
        public string Estatus { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public string Concepto { get; set; }
        public string Referencia { get; set; }
        public Nullable<System.DateTime> FechaConclusion { get; set; }
        public Nullable<System.DateTime> FechaCancelacion { get; set; }
        public string Proyecto { get; set; }
        public string OrigenModulo { get; set; }
        public Nullable<int> OrigenID { get; set; }
        public string WFEstado { get; set; }
        public string WFUsuario { get; set; }
        public string Almacen { get; set; }
        public string Proveedor { get; set; }
        public bool GeneracionMovProgresiva { get; set; }
        public Nullable<int> FrecuenciaNumero { get; set; }
        public string FrecuenciaPeriodo { get; set; }
        public string FrecuenciaDias { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public string UbicacionD { get; set; }
        public string UbicacionA { get; set; }
        public string Linea { get; set; }
        public string SubLinea { get; set; }
        public string Marca { get; set; }
        public string RankHC { get; set; }
        public bool GeneracionObjetivo { get; set; }
        public Nullable<int> CantidadArticulos { get; set; }
        public string GOPeriodo { get; set; }
        public string SeleccionArticulos { get; set; }
    }
}
