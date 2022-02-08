namespace Shamrik.DI.TransmittingDependencies.HttpContext.Services
{
    public class MessageService
    {
        private IMessageSender MessageSender { get; }

        public MessageService(IMessageSender messageSender)
        {
            MessageSender = messageSender;
        }

        public string Send()
        {
            return MessageSender.Send();
        }
    }
}