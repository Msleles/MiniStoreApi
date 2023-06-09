using MiniStore.Application.Interfaces;
using MiniStore.Application.Interfaces.Notificador;

namespace MiniStore.Application.Services
{
    public class CategoriaService : BaseService , ICategoriaService
    {
        public CategoriaService(INotificationService _notificador) : base(_notificador) { }
    }
}
