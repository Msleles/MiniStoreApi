namespace MiniStore.Application.Interfaces.Notificador
{
    public interface INotificationService
    {
        bool HaveNotification();
        List<Notify> GetNotifications();
        void Handle(Notify notify);
    }
}
