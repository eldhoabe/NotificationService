using System;

namespace NotifcationService
{
    class Program
    {
        static void Main(string[] args)
        {

            INotificationService smsNotification = new SmsService("9895070723", new SmsSender());
            smsNotification.Notify("sms content");


            INotificationService mailNotification = new MailService("eldhoabe.07@gmail.com", "9895070723");
            mailNotification.Notify("mailContent");



            Console.ReadLine();
        }
    }


   
}
