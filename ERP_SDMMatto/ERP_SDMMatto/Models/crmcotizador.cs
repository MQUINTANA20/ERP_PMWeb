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
    
    public partial class crmcotizador
    {
        public int ID { get; set; }
        public int Propuesta { get; set; }
        public int RenglonID { get; set; }
        public string UnidadUso { get; set; }
        public string TipoUnidad { get; set; }
        public string Proveedor { get; set; }
        public Nullable<int> IDCarroceria { get; set; }
        public string Carroceria { get; set; }
        public string Modelo { get; set; }
        public string Moneda { get; set; }
        public string Observaciones { get; set; }
        public string Comentarios { get; set; }
        public string MarcaUsados { get; set; }
        public Nullable<int> AnoUsados { get; set; }
        public string VINUsados { get; set; }
        public string SpecCamionUsados { get; set; }
        public string CarroceriaUsados { get; set; }
        public string SpecCarroceriaUsados { get; set; }
        public string OrdenCompraUsados { get; set; }
    }
}
