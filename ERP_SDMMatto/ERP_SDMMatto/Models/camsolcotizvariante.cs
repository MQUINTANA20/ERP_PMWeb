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
    
    public partial class camsolcotizvariante
    {
        public int IDVariante { get; set; }
        public Nullable<decimal> TCambioCompraAnt { get; set; }
        public Nullable<decimal> TCambioCompraAct { get; set; }
        public Nullable<System.DateTime> FechaModCompra { get; set; }
        public Nullable<decimal> TCambioVentaAnt { get; set; }
        public Nullable<decimal> TCambioVentaAct { get; set; }
        public Nullable<System.DateTime> FechaModVenta { get; set; }
        public Nullable<decimal> PreentregaAnt { get; set; }
        public Nullable<decimal> PreentregaAct { get; set; }
        public Nullable<System.DateTime> FechaModPre { get; set; }
        public Nullable<int> IdTipo1 { get; set; }
        public Nullable<int> IdReglaAntPasaje { get; set; }
        public Nullable<int> IdReglaActPasaje { get; set; }
        public Nullable<System.DateTime> FechaModPasaje { get; set; }
        public Nullable<int> IdTipo2 { get; set; }
        public Nullable<int> IdReglaAntLigero { get; set; }
        public Nullable<int> IdReglaActLigero { get; set; }
        public Nullable<System.DateTime> FechaModLigero { get; set; }
        public Nullable<int> IdTipo3 { get; set; }
        public Nullable<int> IdReglaAntCarga { get; set; }
        public Nullable<int> IdReglaActCarga { get; set; }
        public Nullable<System.DateTime> FechaModCarga { get; set; }
        public Nullable<int> IdTipo4 { get; set; }
        public Nullable<int> IdReglaAntSevero { get; set; }
        public Nullable<int> IdReglaActSevero { get; set; }
        public Nullable<System.DateTime> FechaModSevero { get; set; }
        public Nullable<int> IdTipo5 { get; set; }
        public Nullable<int> IdReglaAntTractos { get; set; }
        public Nullable<int> IdReglaActTractos { get; set; }
        public Nullable<System.DateTime> FechaModTractos { get; set; }
        public Nullable<int> IdTipo6 { get; set; }
        public Nullable<int> IdReglaAntUsados { get; set; }
        public Nullable<int> IdReglaActUsados { get; set; }
        public Nullable<System.DateTime> FechaModUsados { get; set; }
        public Nullable<int> IdTipo7 { get; set; }
        public Nullable<int> IdReglaAntFSL { get; set; }
        public Nullable<int> IdReglaActFSL { get; set; }
        public Nullable<System.DateTime> FechaModFSL { get; set; }
        public Nullable<int> IdProvaAnt { get; set; }
        public Nullable<int> IdProva { get; set; }
        public Nullable<System.DateTime> FechaModProva { get; set; }
        public Nullable<decimal> Margen1 { get; set; }
        public Nullable<decimal> Margen2 { get; set; }
        public Nullable<System.DateTime> FechaModMargen { get; set; }
        public Nullable<decimal> GastosContDls { get; set; }
        public Nullable<decimal> GastosContNAL { get; set; }
        public Nullable<System.DateTime> FechaModGastos { get; set; }
        public Nullable<decimal> TasaIntDls { get; set; }
        public Nullable<decimal> TasaIntNAL { get; set; }
        public Nullable<System.DateTime> FechaModTasa { get; set; }
        public Nullable<decimal> IVA0 { get; set; }
        public Nullable<decimal> IVA1 { get; set; }
        public Nullable<decimal> IVA2 { get; set; }
        public Nullable<System.DateTime> FechaModIVA { get; set; }
        public Nullable<decimal> TasaFSLDLS { get; set; }
        public Nullable<decimal> TasaFSLMN { get; set; }
        public Nullable<decimal> ResidualFSLCot { get; set; }
        public Nullable<decimal> ResidualFSLCCot { get; set; }
        public Nullable<System.DateTime> FechaModParFSL { get; set; }
        public Nullable<decimal> TasaFSLDLS12 { get; set; }
        public Nullable<decimal> TasaFSLDLS24 { get; set; }
        public Nullable<decimal> TasaFSLDLS36 { get; set; }
        public Nullable<decimal> TasaFSLDLS48 { get; set; }
        public Nullable<decimal> TasaFSLDLS60 { get; set; }
        public Nullable<decimal> TasaFSLDLS72 { get; set; }
        public Nullable<decimal> TasaFSLDLS84 { get; set; }
        public Nullable<System.DateTime> FechaModTasaFSLDLS { get; set; }
        public Nullable<decimal> TasaFSLMN12 { get; set; }
        public Nullable<decimal> TasaFSLMN24 { get; set; }
        public Nullable<decimal> TasaFSLMN36 { get; set; }
        public Nullable<decimal> TasaFSLMN48 { get; set; }
        public Nullable<decimal> TasaFSLMN60 { get; set; }
        public Nullable<decimal> TasaFSLMN72 { get; set; }
        public Nullable<decimal> TasaFSLMN84 { get; set; }
        public Nullable<System.DateTime> FechaModTasaFSLMN { get; set; }
        public Nullable<decimal> ValResFLS12 { get; set; }
        public Nullable<decimal> ValResFLS24 { get; set; }
        public Nullable<decimal> ValResFLS36 { get; set; }
        public Nullable<decimal> ValResFLS48 { get; set; }
        public Nullable<decimal> ValResFLS60 { get; set; }
        public Nullable<decimal> ValResFLS72 { get; set; }
        public Nullable<decimal> ValResFLS84 { get; set; }
        public Nullable<System.DateTime> FechaModVRFSL { get; set; }
        public Nullable<decimal> ComisionFSL { get; set; }
        public Nullable<int> RentasFSL { get; set; }
        public Nullable<decimal> GastosLegalesFSLDLS { get; set; }
        public Nullable<decimal> GastosLegalesFSLMN { get; set; }
        public Nullable<decimal> MMovilFSL { get; set; }
        public Nullable<decimal> EquipoMMovilFSL { get; set; }
        public Nullable<System.DateTime> FechaModVariablesFSL { get; set; }
        public Nullable<decimal> InflAnual12 { get; set; }
        public Nullable<decimal> InflAnual24 { get; set; }
        public Nullable<decimal> InflAnual36 { get; set; }
        public Nullable<decimal> InflAnual48 { get; set; }
        public Nullable<decimal> InflAnual60 { get; set; }
        public Nullable<decimal> InflAnual72 { get; set; }
        public Nullable<decimal> InflAnual84 { get; set; }
        public Nullable<System.DateTime> FechaModInfAnual { get; set; }
        public Nullable<decimal> PreentregaAntT { get; set; }
        public Nullable<decimal> PreentregaActT { get; set; }
        public Nullable<System.DateTime> FechaModPreT { get; set; }
        public Nullable<decimal> PreentregaAntC { get; set; }
        public Nullable<decimal> PreentregaActC { get; set; }
        public Nullable<System.DateTime> FechaModPreC { get; set; }
        public Nullable<decimal> PreentregaAntL { get; set; }
        public Nullable<decimal> PreentregaActL { get; set; }
        public Nullable<System.DateTime> FechaModPreL { get; set; }
        public Nullable<decimal> PreentregaAntP { get; set; }
        public Nullable<decimal> PreentregaActP { get; set; }
        public Nullable<System.DateTime> FechaModPreP { get; set; }
        public Nullable<decimal> PreentregaAntS { get; set; }
        public Nullable<decimal> PreentregaActS { get; set; }
        public Nullable<System.DateTime> FechaModPreS { get; set; }
        public Nullable<decimal> ISAN { get; set; }
        public Nullable<System.DateTime> FechaModISAN { get; set; }
        public Nullable<decimal> LimiteInferior1 { get; set; }
        public Nullable<decimal> LimiteInferior2 { get; set; }
        public Nullable<decimal> LimiteInferior3 { get; set; }
        public Nullable<decimal> LimiteInferior4 { get; set; }
        public Nullable<decimal> LimiteInferior5 { get; set; }
        public Nullable<decimal> LimiteSuperior1 { get; set; }
        public Nullable<decimal> LimiteSuperior2 { get; set; }
        public Nullable<decimal> LimiteSuperior3 { get; set; }
        public Nullable<decimal> LimiteSuperior4 { get; set; }
        public Nullable<decimal> LimiteSuperior5 { get; set; }
        public Nullable<decimal> CuotaFija1 { get; set; }
        public Nullable<decimal> CuotaFija2 { get; set; }
        public Nullable<decimal> CuotaFija3 { get; set; }
        public Nullable<decimal> CuotaFija4 { get; set; }
        public Nullable<decimal> CuotaFija5 { get; set; }
        public Nullable<decimal> PorcExcedente1 { get; set; }
        public Nullable<decimal> PorcExcedente2 { get; set; }
        public Nullable<decimal> PorcExcedente3 { get; set; }
        public Nullable<decimal> PorcExcedente4 { get; set; }
        public Nullable<decimal> PorcExcedente5 { get; set; }
        public Nullable<System.DateTime> FechaModCalculoISAN { get; set; }
        public Nullable<decimal> Faldones { get; set; }
        public Nullable<decimal> Deflector { get; set; }
        public Nullable<decimal> RinAlum { get; set; }
        public Nullable<decimal> Deslizable { get; set; }
        public Nullable<decimal> Apu { get; set; }
        public Nullable<decimal> UltraShift { get; set; }
        public Nullable<System.DateTime> FechaModCompTractos { get; set; }
        public Nullable<decimal> TCVentaFSLMtto { get; set; }
        public Nullable<decimal> combtractosu { get; set; }
        public Nullable<decimal> combcargau { get; set; }
        public Nullable<decimal> combligerosu { get; set; }
        public Nullable<decimal> combpasajeu { get; set; }
        public Nullable<decimal> combotrosu { get; set; }
        public Nullable<System.DateTime> FechaModCombusados { get; set; }
        public Nullable<decimal> ComVendT { get; set; }
        public Nullable<decimal> ComMinVendT { get; set; }
        public Nullable<decimal> DctoMaxVendT { get; set; }
        public Nullable<decimal> DctoMaxGteT { get; set; }
        public Nullable<decimal> PorcDctoT { get; set; }
        public Nullable<decimal> ComVendC { get; set; }
        public Nullable<decimal> ComMinVendC { get; set; }
        public Nullable<decimal> DctoMaxVendC { get; set; }
        public Nullable<decimal> DctoMaxGteC { get; set; }
        public Nullable<decimal> PorcDctoC { get; set; }
        public Nullable<decimal> ComVendP { get; set; }
        public Nullable<decimal> ComMinVendP { get; set; }
        public Nullable<decimal> DctoMaxVendP { get; set; }
        public Nullable<decimal> DctoMaxGteP { get; set; }
        public Nullable<decimal> PorcDctoP { get; set; }
        public Nullable<decimal> ComVendL { get; set; }
        public Nullable<decimal> ComMinVendL { get; set; }
        public Nullable<decimal> DctoMaxVendL { get; set; }
        public Nullable<decimal> DctoMaxGteL { get; set; }
        public Nullable<decimal> PorcDctoL { get; set; }
        public Nullable<decimal> ComVendO { get; set; }
        public Nullable<decimal> ComMinVendO { get; set; }
        public Nullable<decimal> DctoMaxVendO { get; set; }
        public Nullable<decimal> DctoMaxGteO { get; set; }
        public Nullable<decimal> PorcDctoO { get; set; }
        public Nullable<decimal> SurCharge { get; set; }
        public Nullable<System.DateTime> FechaModSurCharge { get; set; }
        public string Leyenda1 { get; set; }
        public string Leyenda2 { get; set; }
        public string Leyenda3 { get; set; }
        public Nullable<System.DateTime> FechaModLeyendas { get; set; }
        public Nullable<decimal> PorcDctoNegT { get; set; }
        public Nullable<decimal> PorcDctoNegC { get; set; }
        public Nullable<decimal> PorcDctoNegP { get; set; }
        public Nullable<decimal> PorcDctoNegL { get; set; }
        public Nullable<decimal> PorcDctoNegO { get; set; }
    }
}
