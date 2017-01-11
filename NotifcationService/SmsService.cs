using System;

namespace NotifcationService
{
    public class SmsService : INotificationService
    {
        readonly string phoneNumber;
        readonly ISmsSender sender;

        public SmsService(string phone, ISmsSender send)
        {
            this.phoneNumber = phone;
            this.sender = send;
        }

        public bool Notify(string message)
        {
            Console.WriteLine("Sms service invoked" + phoneNumber, message);
            return sender.SendSms(message);

        }
    }


    
}
