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
    
    public partial class crmcotizadorcosteo
    {
        public int ID { get; set; }
        public int Propuesta { get; set; }
        public int RenglonID { get; set; }
        public Nullable<decimal> TCVenta { get; set; }
        public Nullable<decimal> TCCompra { get; set; }
        public Nullable<bool> MonedaOrigen { get; set; }
        public Nullable<bool> Dolares { get; set; }
        public Nullable<bool> Nacional { get; set; }
        public Nullable<decimal> PorcChasis { get; set; }
        public Nullable<decimal> PorcCarroceria { get; set; }
        public Nullable<bool> PrecioXPorcUtilidad { get; set; }
        public Nullable<bool> PrecioXTotalVenta { get; set; }
        public Nullable<int> CantidadUnidades { get; set; }
        public Nullable<bool> Contado { get; set; }
        public Nullable<bool> CreditoExterno { get; set; }
        public Nullable<bool> CreditoInterno { get; set; }
        public Nullable<bool> FSL { get; set; }
        public Nullable<decimal> precioventasNSIP { get; set; }
        public Nullable<decimal> precioventachasisNSIP { get; set; }
        public Nullable<decimal> precioventacarroceriaNSIP { get; set; }
        public Nullable<decimal> costocamionNSIP { get; set; }
        public Nullable<decimal> preentregaNSIP { get; set; }
        public Nullable<decimal> siusdctoplantaNSIP { get; set; }
        public Nullable<decimal> descuentointernoNSIP { get; set; }
        public Nullable<decimal> otroscomponentescamionSIP { get; set; }
        public Nullable<decimal> isanSIP { get; set; }
        public Nullable<decimal> IsanPorcSIP { get; set; }
        public Nullable<decimal> subtotalcamionSIP { get; set; }
        public Nullable<decimal> carroceriaNSIP { get; set; }
        public Nullable<decimal> ComponentescarroceriaNSIP { get; set; }
        public Nullable<decimal> subtotalcarroceriaSIP { get; set; }
        public Nullable<decimal> subsidiousadosSIP { get; set; }
        public Nullable<decimal> subsidiotipocambioSIP { get; set; }
        public Nullable<decimal> subsidioCreditoSIP { get; set; }
        public Nullable<decimal> CreditoInternoSIP { get; set; }
        public Nullable<decimal> SubtotalOtrosCostosSIP { get; set; }
        public Nullable<decimal> CostoTotalSIP { get; set; }
        public Nullable<decimal> CostoChasisSIP { get; set; }
        public Nullable<decimal> CostoCarroceriaSIP { get; set; }
        public Nullable<decimal> UtilidadTotalSIP { get; set; }
        public Nullable<decimal> UtilidadchasisSIP { get; set; }
        public Nullable<decimal> UtilidadCarroceriaSIP { get; set; }
        public Nullable<decimal> precioventasNSID { get; set; }
        public Nullable<decimal> precioventachasisNSID { get; set; }
        public Nullable<decimal> precioventacarroceriaNSID { get; set; }
        public Nullable<decimal> costocamionNSID { get; set; }
        public Nullable<decimal> preentregaNSID { get; set; }
        public Nullable<decimal> siusdctoplantaNSID { get; set; }
        public Nullable<decimal> descuentointernoNSID { get; set; }
        public Nullable<decimal> otroscomponentescamionSID { get; set; }
        public Nullable<decimal> isanSID { get; set; }
        public Nullable<decimal> IsanPorcSID { get; set; }
        public Nullable<decimal> subtotalcamionSID { get; set; }
        public Nullable<decimal> carroceriaNSID { get; set; }
        public Nullable<decimal> ComponentescarroceriaNSID { get; set; }
        public Nullable<decimal> subtotalcarroceriaSID { get; set; }
        public Nullable<decimal> subsidiousadosSID { get; set; }
        public Nullable<decimal> subsidiotipocambioSID { get; set; }
        public Nullable<decimal> subsidioCreditoSID { get; set; }
        public Nullable<decimal> CreditoInternoSID { get; set; }
        public Nullable<decimal> SubtotalOtrosCostosSID { get; set; }
        public Nullable<decimal> CostoTotalSID { get; set; }
        public Nullable<decimal> CostoChasisSID { get; set; }
        public Nullable<decimal> CostoCarroceriaSID { get; set; }
        public Nullable<decimal> UtilidadTotalSID { get; set; }
        public Nullable<decimal> UtilidadchasisSID { get; set; }
        public Nullable<decimal> UtilidadCarroceriaSID { get; set; }
        public Nullable<decimal> precioventasNCIP { get; set; }
        public Nullable<decimal> precioventachasisNCIP { get; set; }
        public Nullable<decimal> precioventacarroceriaNCIP { get; set; }
        public Nullable<decimal> costocamionNCIP { get; set; }
        public Nullable<decimal> preentregaNCIP { get; set; }
        public Nullable<decimal> siusdctoplantaNCIP { get; set; }
        public Nullable<decimal> descuentointernoNCIP { get; set; }
        public Nullable<decimal> otroscomponentescamionCIP { get; set; }
        public Nullable<decimal> isanCIP { get; set; }
        public Nullable<decimal> IsanPorcCIP { get; set; }
        public Nullable<decimal> subtotalcamionCIP { get; set; }
        public Nullable<decimal> carroceriaNCIP { get; set; }
        public Nullable<decimal> ComponentescarroceriaNCIP { get; set; }
        public Nullable<decimal> subtotalcarroceriaCIP { get; set; }
        public Nullable<decimal> subsidiousadosCIP { get; set; }
        public Nullable<decimal> subsidiotipocambioCIP { get; set; }
        public Nullable<decimal> subsidioCreditoCIP { get; set; }
        public Nullable<decimal> CreditoInternoCIP { get; set; }
        public Nullable<decimal> SubtotalOtrosCostosCIP { get; set; }
        public Nullable<decimal> CostoTotalCIP { get; set; }
        public Nullable<decimal> CostoChasisCIP { get; set; }
        public Nullable<decimal> CostoCarroceriaCIP { get; set; }
        public Nullable<decimal> UtilidadTotalCIP { get; set; }
        public Nullable<decimal> UtilidadchasisCIP { get; set; }
        public Nullable<decimal> UtilidadCarroceriaCIP { get; set; }
        public Nullable<decimal> precioventasNCID { get; set; }
        public Nullable<decimal> precioventachasisNCID { get; set; }
        public Nullable<decimal> precioventacarroceriaNCID { get; set; }
        public Nullable<decimal> costocamionNCID { get; set; }
        public Nullable<decimal> preentregaNCID { get; set; }
        public Nullable<decimal> siusdctoplantaNCID { get; set; }
        public Nullable<decimal> descuentointernoNCID { get; set; }
        public Nullable<decimal> otroscomponentescamionCID { get; set; }
        public Nullable<decimal> isanCID { get; set; }
        public Nullable<decimal> IsanPorcCID { get; set; }
        public Nullable<decimal> subtotalcamionCID { get; set; }
        public Nullable<decimal> carroceriaNCID { get; set; }
        public Nullable<decimal> ComponentescarroceriaNCID { get; set; }
        public Nullable<decimal> subtotalcarroceriaCID { get; set; }
        public Nullable<decimal> subsidiousadosCID { get; set; }
        public Nullable<decimal> subsidiotipocambioCID { get; set; }
        public Nullable<decimal> subsidioCreditoCID { get; set; }
        public Nullable<decimal> CreditoInternoCID { get; set; }
        public Nullable<decimal> SubtotalOtrosCostosCID { get; set; }
        public Nullable<decimal> CostoTotalCID { get; set; }
        public Nullable<decimal> CostoChasisCID { get; set; }
        public Nullable<decimal> CostoCarroceriaCID { get; set; }
        public Nullable<decimal> UtilidadTotalCID { get; set; }
        public Nullable<decimal> UtilidadchasisCID { get; set; }
        public Nullable<decimal> UtilidadCarroceriaCID { get; set; }
        public Nullable<decimal> ISANporc { get; set; }
        public Nullable<decimal> SubsidiotipocambioPorc { get; set; }
        public Nullable<decimal> UtilidadChasisMB { get; set; }
        public Nullable<decimal> UtilidadCarroceriaMB { get; set; }
        public Nullable<decimal> PrecioPubTotalUSIP { get; set; }
        public Nullable<decimal> PrecioVentaUSIP { get; set; }
        public Nullable<decimal> PrecioPubUSIP { get; set; }
        public Nullable<decimal> PrecioVentaUsadosSIP { get; set; }
        public Nullable<decimal> AdecuacionesUSIP { get; set; }
        public Nullable<decimal> DescuentoUSIP { get; set; }
        public Nullable<decimal> PrecioPubCarUSIP { get; set; }
        public Nullable<decimal> PrecioVentaCaruSIP { get; set; }
        public Nullable<decimal> AdecuacionescarUSIP { get; set; }
        public Nullable<decimal> DescuentoCarUSIP { get; set; }
        public Nullable<decimal> SubsidioCreditoUSIP { get; set; }
        public Nullable<decimal> CreditoInternoUSIP { get; set; }
        public Nullable<decimal> SubtotalOtrosCostosUSIP { get; set; }
        public Nullable<decimal> DescuentoTotalUSIP { get; set; }
        public Nullable<decimal> PrecioPubTotalUSID { get; set; }
        public Nullable<decimal> PrecioVentaUSID { get; set; }
        public Nullable<decimal> PrecioPubUSID { get; set; }
        public Nullable<decimal> PrecioVentaUsadosSID { get; set; }
        public Nullable<decimal> AdecuacionesUSID { get; set; }
        public Nullable<decimal> DescuentoUSID { get; set; }
        public Nullable<decimal> PrecioPubCarUSID { get; set; }
        public Nullable<decimal> PrecioVentaCaruSID { get; set; }
        public Nullable<decimal> AdecuacionescarUSID { get; set; }
        public Nullable<decimal> DescuentoCarUSID { get; set; }
        public Nullable<decimal> SubsidioCreditoUSID { get; set; }
        public Nullable<decimal> CreditoInternoUSID { get; set; }
        public Nullable<decimal> SubtotalOtrosCostosUSID { get; set; }
        public Nullable<decimal> DescuentoTotalUSID { get; set; }
        public Nullable<decimal> PrecioPubTotalUCIP { get; set; }
        public Nullable<decimal> PrecioVentaUCIP { get; set; }
        public Nullable<decimal> PrecioPubUCIP { get; set; }
        public Nullable<decimal> PrecioVentaUsadosCIP { get; set; }
        public Nullable<decimal> AdecuacionesUCIP { get; set; }
        public Nullable<decimal> DescuentoUCIP { get; set; }
        public Nullable<decimal> PrecioPubCarUCIP { get; set; }
        public Nullable<decimal> PrecioVentaCaruCIP { get; set; }
        public Nullable<decimal> AdecuacionescarUCIP { get; set; }
        public Nullable<decimal> DescuentoCarUCIP { get; set; }
        public Nullable<decimal> SubsidioCreditoUCIP { get; set; }
        public Nullable<decimal> CreditoInternoUCIP { get; set; }
        public Nullable<decimal> SubtotalOtrosCostosUCIP { get; set; }
        public Nullable<decimal> DescuentoTotalUCIP { get; set; }
        public Nullable<decimal> SubsidioCredito { get; set; }
        public Nullable<decimal> PrecioPubTotalUCID { get; set; }
        public Nullable<decimal> PrecioVentaUCID { get; set; }
        public Nullable<decimal> PrecioPubUCID { get; set; }
        public Nullable<decimal> PrecioVentaUsadosCID { get; set; }
        public Nullable<decimal> AdecuacionesUCID { get; set; }
        public Nullable<decimal> DescuentoUCID { get; set; }
        public Nullable<decimal> PrecioPubCarUCID { get; set; }
        public Nullable<decimal> PrecioVentaCaruCID { get; set; }
        public Nullable<decimal> AdecuacionescarUCID { get; set; }
        public Nullable<decimal> DescuentoCarUCID { get; set; }
        public Nullable<decimal> SubsidioCreditoUCID { get; set; }
        public Nullable<decimal> CreditoInternoUCID { get; set; }
        public Nullable<decimal> SubtotalOtrosCostosUCID { get; set; }
        public Nullable<decimal> DescuentoTotalUCID { get; set; }
        public Nullable<decimal> ComisionBaseU { get; set; }
        public Nullable<decimal> ComisionFinalU { get; set; }
        public Nullable<decimal> LimiteDescuentoU { get; set; }
        public Nullable<decimal> DescuentoComisionU { get; set; }
        public Nullable<decimal> ExcesoDescU { get; set; }
        public Nullable<decimal> ComisionMinimaU { get; set; }
        public string Leyenda1 { get; set; }
        public string Leyenda2 { get; set; }
        public string Leyenda3 { get; set; }
        public Nullable<decimal> Subsidiocreditoporc { get; set; }
        public Nullable<decimal> UtilidadTotalMB { get; set; }
        public string MonedaOr { get; set; }
        public Nullable<decimal> CostoFinancSIP { get; set; }
        public Nullable<decimal> CostoFinancCIP { get; set; }
        public Nullable<decimal> CostoFinancSID { get; set; }
        public Nullable<decimal> CostoFinancCID { get; set; }
        public string MonedaOrC { get; set; }
        public string MonedaOrChasis { get; set; }
    }
}