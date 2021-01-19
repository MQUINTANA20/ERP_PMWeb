using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifications.ModelTemplates  {
    public class FailValidationPurchaseOrderModel : BaseModel {

        private string nombreCompletoUsuario ;
        private string numeroOrdenCompra;
        private List<string> errors;

        public string NombreCompletoUsuario {
            get {
                return nombreCompletoUsuario;
            }

            set {
                nombreCompletoUsuario = value;
            }
        }

        public string NumeroOrdenCompra {
            get {
                return numeroOrdenCompra;
            }

            set {
                numeroOrdenCompra = value;
            }
        }

        public List<string> Errors {
            get {
                return errors;
            }

            set {
                errors = value;
            }
        }
    }
}
