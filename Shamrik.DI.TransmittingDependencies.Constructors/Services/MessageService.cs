namespace Shamrik.DI.TransmittingDependencies.Constructors.Services
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