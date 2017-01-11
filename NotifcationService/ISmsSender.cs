namespace NotifcationService
{
    public interface ISmsSender
    {
        bool SendSms(string message);
    }
}
