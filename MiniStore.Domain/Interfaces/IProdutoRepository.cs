using MiniStore.Domain.Entities;

namespace MiniStore.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task AddProdutoAsync (Produto produto);
    }
}
