namespace Shamrik.DI.TransmittingDependencies.HttpContext.Services
{
    public class SmsMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message sent by SMS";

        }
    }
}