using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifcationService
{
    public class SmsService : INotificationService
    {
        readonly string phoneNumber;
        readonly string message;
        readonly ISmsSender sender;
        public SmsService(string phone, string msg, ISmsSender send)
        {
            this.phoneNumber = phone;
            this.message = msg;
            this.sender = send;
        }

        public bool Notify()
        {
            Console.WriteLine("Sms service invoked" + phoneNumber, message);
            return sender.SendSms(message);
            
        }
    }


    public interface ISmsSender
    {
        bool SendSms(string msg);
    }

    public class SmsSender : ISmsSender
    {
        public bool SendSms(string msg)
        {
            return true;
        }
    }
}
