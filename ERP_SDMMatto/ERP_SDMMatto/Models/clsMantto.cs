using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ERP_SDMMatto.Models
{
    public class clsMantto
    {

        [Display(Name = "ID")]
        public int IdInterno { get; set; }

        [Display(Name = "Eval")]
        public bool Eval { get; set; }

        [Display(Name = "Item a Revisar")]
        public string ItemARevisar { get; set; }

         [Display(Name = "Rojo")]
        public bool Rojo { get; set; }

        [Display(Name = "Refacciones Requeridas")]
        public string RefRequeridas { get; set; }
       
        [Required]
        [Display(Name = "Comentarios")]
        public string Comentarios { get; set; }

    }

    public class clsMensajesSP { 
        public string msg { get; set; }

        public int nmsg { get; set; }
    }

    public class clsUnidad
    {
        public int idUnidad { get; set; }

        [Display(Name = "VIN / No. Economico Unidad")]
        public string Serie { get; set; }

        [Display(Name = "Tipo Busqueda")]
        public int TipoSelect { get; set; }

        [Display(Name = "KM"), Required]
        public int KM { get; set; }

        public IEnumerable<SelectListItem> CatTipoBUnidad { get; set; }
    }

    public class clsUnidadDetalle
    {
        public int ID { get; set; }

        [Display(Name = "Serie")]
        public string Serie { get; set; }

        [Display(Name = "Movimiento")]
        public string Movimiento { get; set; }

        [Display(Name = "Fecha Emision")]
        public string FechaEmision { get; set; }

        [Display(Name = "Folio")]
        public string Folio { get; set; }

        [Display(Name = "Tipo Mantenimiento")]
        public string TipoMantto { get; set; }

        [Display(Name = "Servicio")]
        public string Servicio { get; set; }

        [Display(Name = "Tecnico")]
        public string Tecnico { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }


        [Display(Name = "Tipo")]
        public string Tipo { get; set; }
        [Display(Name = "Marca")]
        public string Marca { get; set; }

        [Display(Name = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Año")]
        public string Anio { get; set; }
        [Display(Name = "Carroceria")]
        public string Carroceria { get; set; }

        [Display(Name = "Tipo Motor")]
        public string TipoMotor { get; set; }

        [Display(Name = "No Economico")]
        public string NOEconomico { get; set; }
        [Display(Name = "No Motor")]
        public string NOMotor { get; set; }

        [Display(Name = "Placas")]
        public string Placas { get; set; }

        [Display(Name = "Color")]
        public string Color { get; set; }

    }

    public class clsQuickCheck
    {
        public string IDUnidad { get; set; }
        public int IDInterno { get; set; }
        public int IDOrden { get; set; }
        public bool Eval { get; set; }
        public string ItemARevisar { get; set; }
        public bool Rojo { get; set; }
        public bool Verde { get; set; }

        public string VerdeRojo { get; set; }
        [Required]
        public string Comentarios { get; set; }

        public string Refacciones { get; set; }

        public IEnumerable<clsEvaluacion> Evaluacion { get; set; }
        public int KM { get; set; }
    }

    public class clsEvaluacion
    {
        public int Id { get; set; }
        public int IdInterno { get; set; }
        public string ConceptoEvaluacion { get; set;
        }

        public string Evaluacion { get; set; }

        public  string Unidad { get; set; }

        public decimal Valor { get; set; }


    }
    public class Events
    {
        public string idMsg { get; set; }
      
        public string Msg { get; set; }
    }

    public class clsSucursales
    {
        public int Sucursal { get; set; }

        public string Nombre { get; set; }
    }

    public class clsRefacciones {

        public int IdOrden { get; set; }
        public string IdUnidad { get; set; }
        public int KM { get; set; }

        public string Linea { get; set; }
        public string Marca { get; set; }
        public string Articulo { get; set; }

        public string Descripcion { get; set; }
        public Decimal Cantidad { get; set; }
        public string Unidad { get; set; }

    }

    public class clsMO
    {

        public int IdOrden { get; set; }
        public string IdUnidad { get; set; }
        public int KM { get; set; }

        public string Codigo { get; set; }
        public string MO { get; set; }
        public string TiempoEstimado { get; set; }

        public string TipoUnidadAliado { get; set; }
        
    }

    public class clsTOTS
    {

        public int IdOrden { get; set; }
        public string IdUnidad { get; set; }
        public int KM { get; set; }

        public string Proovedor { get; set; }
        public string Nombre { get; set; }
        public string Articulo { get; set; }

        public string Descripcion { get; set; }

    }

    public class clsOrdenServicio
    {
        public string unidad { get; set; }

        public string CatSelectConcpeto { get; set; }
        public IEnumerable<SelectListItem> CatConcepto { get; set; }

        public string CatSelectTipoMantenimiento { get; set; }

        public IEnumerable<SelectListItem> CatTipoMantenimiento { get; set; }

        public string CatSelectServicio { get; set; }

        public IEnumerable<SelectListItem> CatServicio { get; set; }


    }

    public class clsMsgSP2
    {
        public string Concepto { get; set; }
    }
}