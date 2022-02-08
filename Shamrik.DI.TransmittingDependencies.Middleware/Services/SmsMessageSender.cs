namespace Shamrik.DI.TransmittingDependencies.Middleware.Services
{
    public class SmsMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message sent by SMS";

        }
    }
}