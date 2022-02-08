namespace Shamrik.DI.TransmittingDependencies.ApplicationServices.Services
{
    public class SmsMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message sent by SMS";

        }
    }
}