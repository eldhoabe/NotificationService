using System;

namespace NotifcationService
{
    public class MailService : INotificationService
    {
        readonly string _address;
        readonly string _subject;

        public MailService(string address, string subject)
        {
            this._address = address;
            this._subject = subject;
        }

        public bool Notify(string message)
        {
            Console.WriteLine("Email service invoked " + _address + _subject + message);
            return true;
           
        }
    }
}
