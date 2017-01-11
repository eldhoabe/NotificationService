using NotifcationService;

namespace NotificationService.Tests
{

    class MockSmsService : INotificationService
    {

        public bool Notify(string message)
        {
            return true;
        }
    }

    class MockSender : ISmsSender
    {
        public bool SendSms(string msg)
        {
            return true;
        }
    }


    class MockMailService : INotificationService
    {
        public bool Notify(string message)
        {
            return true;

        }
    }

}
