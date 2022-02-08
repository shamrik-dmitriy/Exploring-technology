namespace Shamrik.DI.TransmittingDependencies.Configure.Services
{
    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message sent by E-Mail";
        }
    }
}