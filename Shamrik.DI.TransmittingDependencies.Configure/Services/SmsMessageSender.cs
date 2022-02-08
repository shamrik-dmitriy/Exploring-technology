namespace Shamrik.DI.TransmittingDependencies.Configure.Services
{
    public class SmsMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message sent by SMS";

        }
    }
}