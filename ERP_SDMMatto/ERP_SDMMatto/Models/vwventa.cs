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
    
    public partial class vwventa
    {
        public int Empresa { get; set; }
        public int Sucursal { get; set; }
        public int ID { get; set; }
        public string Movimiento { get; set; }
        public string Clase { get; set; }
        public Nullable<int> Factor { get; set; }
        public string Folio { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public string Estatus { get; set; }
        public string Moneda { get; set; }
        public string TipoMoneda { get; set; }
        public decimal TipoCambio { get; set; }
        public string Concepto { get; set; }
        public Nullable<int> OrigenID { get; set; }
        public string OrigenModulo { get; set; }
        public string Contacto { get; set; }
        public string ContactoNombre { get; set; }
        public string Contacto2 { get; set; }
        public string Contacto2Nombre { get; set; }
        public string CondicionPago { get; set; }
        public Nullable<System.DateTime> Vencimiento { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public Nullable<decimal> ImportePesos { get; set; }
        public Nullable<decimal> Saldo { get; set; }
    }
}