namespace Shamrik.DI.TransmittingDependencies.Constructors.Services
{
    public class SmsMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message sent by SMS";

        }
    }
}