namespace MiniStore.Application.Interfaces.Notificador
{
    public class Notify
    {
        public Notify(string message)
        {
            Message = message;
        }
        public string Message { get; }
    }
}
