using Microsoft.VisualStudio.TestTools.UnitTesting;
using NotifcationService;

namespace NotificationService.Tests
{
    [TestClass]
    public class NotificationServiceTest
    {
        [TestMethod]
        public void CheckSmsService_Invoked()
        {
            //Arrange
            INotificationService mock = new MockSmsService();
            var user = new User(mock);

            ////Act
            user.CreateUser("fdsf");

            //Assert
            Assert.IsTrue(user.isMailed);

        }


        [TestMethod]
        public void EnsureSmsInvoked()
        {
            INotificationService smsservice = new SmsService("s",new MockSender());


            //Act
            var result = smsservice.Notify("test");

            Assert.IsTrue(result);
        }



        [TestMethod]
        public void EnsureEmailInvoked()
        {
            INotificationService mailservice = new MockMailService();


            //Act
            var result = mailservice.Notify("sms");

            Assert.IsTrue(result);
        }
    }


   
}
