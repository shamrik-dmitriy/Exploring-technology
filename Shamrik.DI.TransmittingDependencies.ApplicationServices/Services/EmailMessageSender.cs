namespace Shamrik.DI.TransmittingDependencies.ApplicationServices.Services
{
    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message sent by E-Mail";
        }
    }
}