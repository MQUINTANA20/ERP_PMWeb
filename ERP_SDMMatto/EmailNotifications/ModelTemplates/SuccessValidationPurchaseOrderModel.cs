using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifications.ModelTemplates
{
    public class SuccessValidationPurchaseOrderModel : BaseModel
    {
        private string nombreCompletoUsuario;
        private string numeroOrdenCompra;
        private string archivoProcesado; //Nombre del archivo procesado
        private string mensajeGeneral;
        private string descripcionErrores;
        private bool bVariasOC;
        public List<string> lPartidasCorrectas; //Agregadas
        public List<string> lPartidasModificadas; //Correctamente
        public List<string> lRecepcionAlmacen; //Correctamente
        public List<string> lPartidasCanceladas; //Correctamente
        public List<string> lPartidasCerradas;
        public List<string> lPartidasDevolucion; 

        public List<string> lErrGenerales;
        public List<ErrOrdenCompra> lErrOrdenCompra; //Errores de las OC
        private int tipo;

        public string sRutaPlantilla;

        public SuccessValidationPurchaseOrderModel()
        {
            numeroOrdenCompra = string.Empty;
            lPartidasCorrectas = new List<string>();
            lPartidasModificadas = new List<string>();
            lRecepcionAlmacen = new List<string>();
            lPartidasCanceladas = new List<string>();
            lPartidasDevolucion = new List<string>();
            lErrGenerales = new List<string>();
            lPartidasCerradas = new List<string>();
            lErrOrdenCompra = new List<ErrOrdenCompra>();
            bVariasOC = false;
            sRutaPlantilla = string.Empty;
        }

        public string NombreCompletoUsuario
        {
            get
            {
                return nombreCompletoUsuario;
            }

            set
            {
                nombreCompletoUsuario = value;
            }
        }

        public string NumeroOrdenCompra
        {
            get
            {
                return numeroOrdenCompra;
            }

            set
            {
                numeroOrdenCompra = value;
            }
        }

        public int Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string ArchivoProcesado
        {
            get
            {
                return archivoProcesado;
            }
            set
            {
                archivoProcesado = value;
            }
        }

        public string MensajeGeneral
        {
            get
            {
                return mensajeGeneral;
            }
            set
            {
                mensajeGeneral = value;
            }
        }

        public string DescripcionErrores
        {
            get
            {
                return descripcionErrores;
            }
            set
            {
                descripcionErrores = value;
            }
        }

        public bool VariasOC
        {
            get { return bVariasOC; }
            set { bVariasOC = value; }
        }
    }

    public class ErrOrdenCompra
    {
        public string OC;
        public string Error;

        public ErrOrdenCompra()
        {
            this.OC = string.Empty;
            this.Error = string.Empty;
        }

        public ErrOrdenCompra(string sOC, string sErr)
        {
            if (sOC == null)
                sOC = string.Empty;

            this.OC = sOC;
            this.Error = sErr;
        }
    }

    public static class TipoNotificacion
    {
        public const int PO_Vendor = 1;
        public const int PO_Buyer = 2;
        public const int PartidasNuevas = 3;
        public const int PartidasModificadas = 4;
        public const int RecepcionAlmacen = 5;
        public const int PartidasCanceladas = 6;
        public const int PartidasEnDevolucion = 7;
        public const int PartidasCerradas = 8;
        public const int SoloOrdenesCompra = 9;
        public const int OCCanceladaProveedor = 10;
        public const int OCCerradaProveedor = 11;
        public const int VariosMovimientos = 99;
    }
}
