namespace Shamrik.DI.CreateService_1.Services
{
    public class SmsMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message sent by SMS";

        }
    }
}