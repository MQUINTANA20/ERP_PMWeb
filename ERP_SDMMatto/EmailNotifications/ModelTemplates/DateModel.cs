using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifications.ModelTemplates
{
    public class DateModel : BaseModel {

    public string Mensaje { get; set; }
    public int Solicitud { get; set; }
	public string Almacen { get; set; }
	public string FechaSolicitada { get; set; }

    public string FechaSolicitadaAnterior { get; set; }
	public int Tarimas { get; set; }
	public string Transporte { get; set; }
	public string CantidadTransporte { get; set; }

    public string nombreProveedor { get; set; }

    }
}
