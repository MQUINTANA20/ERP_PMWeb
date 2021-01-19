using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifications.ModelTemplates
{
    public abstract class BaseModel
    {
        private int idioma;
        private int tipoNotificacion;
        private SmtpClient smptClient;
        private string subject;
        private IList<string> to;
        private IList<string> cc;
        private IList<string> cco;

        public int Idioma
        {
            get
            {
                return idioma;
            }

            set
            {
                idioma = value;
            }
        }

        public int TipoNotificacion
        {
            get
            {
                return tipoNotificacion;
            }

            set
            {
                tipoNotificacion = value;
            }
        }

        public SmtpClient SmptClient
        {
            get
            {
                return smptClient;
            }

            set
            {
                smptClient = value;
            }
        }

        public string Subject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
            }
        }

        public IList<string> To
        {
            get
            {
                return to;
            }

            set
            {
                to = value;
            }
        }

        public IList<string> Cc
        {
            get
            {
                return cc;
            }

            set
            {
                cc = value;
            }
        }

        public IList<string> Cco
        {
            get
            {
                return cco;
            }

            set
            {
                cco = value;
            }
        }
    }
}
