using Microsoft.Extensions.Logging;
using MiniStore.Application.Interfaces;

namespace MiniStore.Application.Services
{
    public class CategoriaService : BaseService, ICategoriaService
    {
        public CategoriaService(ILogger<BaseService> logger, List<string> notifications) : base(logger, notifications)
        {
        }
    }
}
