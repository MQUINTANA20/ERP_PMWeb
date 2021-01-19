using EmailNotifications.ModelTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifications.SenderMail
{
    public interface ISenderMail
    {

        bool EnviarMail(BaseModel baseModel);
    }
}
