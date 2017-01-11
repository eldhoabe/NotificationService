using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifcationService
{
    public class MailService : INotificationService
    {
        readonly string address;
        readonly string subject;
        readonly string message;

        public MailService(string adrss, string subject, string mesg)
        {
            this.address = adrss;
            this.subject = subject;
            this.message = mesg;
        }

        public bool Notify()
        {
            Console.WriteLine("Email service invoked " + address + subject + message);
            return true;
           
        }
    }
}
