using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifications.ModelTemplates
{
    public static class CatalogTypeNotification
    {
        //Tipos de notificacion por Email disponibles
        public const int MAIL_TYPE_RECOVERY_PASSWORD = 1;
        public const int MAIL_TYPE_SUCCESS_PROCESS_PURCHASE_ORDER = 2;
        public const int MAIL_TYPE_FAIL_PROCESS_PURCHASE_ORDER = 3;
        public const int MAIL_TYPE_DATE_CHANGE_NOTIFICATION = 4;
        public const int MAIL_TYPE_SUCCESS_ARCHIVO_SALDOS = 5;
        public const int MAIL_TYPE_FAIL_ARCHIVO_SALDOS = 6;
        public const int MAIL_TYPE_DATE_NOTIFICATION = 7;
    }
}
