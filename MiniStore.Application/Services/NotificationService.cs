using MiniStore.Application.Interfaces.Notificador;

namespace MiniStore.Application.Services
{
    public class NotificationService : INotificationService
    {
        private List<Notify> _notifications;


        public NotificationService()
        {
            _notifications= new List<Notify>();
        }


        public List<Notify> GetNotifications()
        {
            return _notifications;
        }

        public void Handle(Notify notify)
        {
            _notifications.Add(notify);
        }

        public bool HaveNotification()
        {
            return _notifications.Any();
        }
    }
}
