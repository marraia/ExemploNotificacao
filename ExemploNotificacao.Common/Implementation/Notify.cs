using System.Threading;
using ExemploNotificacao.Common.Handler;
using ExemploNotificacao.Common.Interface;
using ExemploNotificacao.Common.Model;
using MediatR;

namespace ExemploNotificacao.Common.Implementation
{
    public class Notify : INotify
    {
        private readonly NotifiyHandler _messageHandler;

        public Notify(INotificationHandler<Notifications> notification)
        {
            _messageHandler = (NotifiyHandler)notification;
        }

        public Notify Invoke()
        {
            return this;
        }

        public bool IsValid()
        {
            return !_messageHandler.HasNotifications();
        }

        public void NewNotification(string key, string message)
        {
            _messageHandler.Handle(new Notifications(key, message), default(CancellationToken));
        }
    }
}
