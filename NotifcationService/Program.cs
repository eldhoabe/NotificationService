using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifcationService
{
    class Program
    {
        static void Main(string[] args)
        {

            //INotificationService smsNotification = new SmsService("9895070723", "hai");
            //smsNotification.Notify();


            INotificationService mailNotification = new MailService("eldhoabe.07@gmail.com", "9895070723", "hai");
            mailNotification.Notify();



            Console.ReadLine();
        }
    }


   
}
