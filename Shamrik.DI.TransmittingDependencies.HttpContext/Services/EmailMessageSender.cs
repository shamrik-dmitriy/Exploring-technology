namespace Shamrik.DI.TransmittingDependencies.HttpContext.Services
{
    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message sent by E-Mail";
        }
    }
}