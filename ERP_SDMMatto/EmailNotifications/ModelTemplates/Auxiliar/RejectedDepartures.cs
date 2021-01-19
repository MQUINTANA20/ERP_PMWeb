using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifications.ModelTemplates.Auxiliar {
    public class RejectedDepartures {

        private string departureNumber;
        private string error;

        public string DepartureNumber {
            get {
                return departureNumber;
            }

            set {
                departureNumber = value;
            }
        }

        public string Error {
            get {
                return error;
            }

            set {
                error = value;
            }
        }
    }
}
