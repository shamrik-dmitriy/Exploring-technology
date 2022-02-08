namespace Shamrik.DI.TransmittingDependencies.Constructors.Services
{
    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message sent by E-Mail";
        }
    }
}