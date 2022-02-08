namespace Shamrik.DI.CreateService_1.Services
{
    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message sent by E-Mail";
        }
    }
}