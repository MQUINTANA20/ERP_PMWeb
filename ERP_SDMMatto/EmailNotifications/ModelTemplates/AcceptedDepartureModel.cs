using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifications.ModelTemplates {
    public class AcceptedDepartureModel : BaseModel {

        private string numeroOrdenCompra;
        private List<string> partidas;

        public string NumeroOrdenCompra {
            get {
                return numeroOrdenCompra;
            }

            set {
                numeroOrdenCompra = value;
            }
        }

        public List<string> Partidas {
            get {
                return partidas;
            }

            set {
                partidas = value;
            }
        }
    }
}
