using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifcationService
{
    public class User
    {
        INotificationService servier;
        public User(INotificationService serv)
        {
            this.servier = serv;
        }


        public bool isMailed;



        public void CreateUser(string name)
        {
            isMailed = servier.Notify();
        }
    }
}
