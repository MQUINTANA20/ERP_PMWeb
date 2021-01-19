using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifications.ModelTemplates {
    public class RejectedDepartureModel : BaseModel {

        private string NumeroOrdenCompra;
        private List<RejectedDepartureModel> rejectedDepartures;

        public string NumeroOrdenCompra1 {
            get {
                return NumeroOrdenCompra;
            }

            set {
                NumeroOrdenCompra = value;
            }
        }

        public List<RejectedDepartureModel> RejectedDepartures {
            get {
                return rejectedDepartures;
            }

            set {
                rejectedDepartures = value;
            }
        }
    }
}
