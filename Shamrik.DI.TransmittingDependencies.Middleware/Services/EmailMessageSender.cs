namespace Shamrik.DI.TransmittingDependencies.Middleware.Services
{
    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message sent by E-Mail";
        }
    }
}