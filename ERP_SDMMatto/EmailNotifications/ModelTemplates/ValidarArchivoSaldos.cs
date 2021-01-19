using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifications.ModelTemplates
{
    public class ValidarArchivoSaldos : BaseModel
    {

        public string NombreUsurio { get; set; }
        public string NombreArchivo { get; set; }
        public string Fecha { get; set; }
        public List<DetalleError> Error { get; set; }
        public string MensajeGral { get; set; }
        public string sCorreos { get; set; }
    }
    public class DetalleError
    {
        public string LineaError { get; set; }
        public string slinea { get; set; }
        public string Error { get; set; }
        public string DetalleErrorLinea { get; set; }
    }
}
