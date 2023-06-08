using Microsoft.Extensions.Logging;
using MiniStore.Application.Interfaces;

namespace MiniStore.Application.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        public ProdutoService(ILogger<BaseService> logger, List<string> notifications) : base(logger, notifications)
        {
        }
    }
}
