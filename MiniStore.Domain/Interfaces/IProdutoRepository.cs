using MiniStore.Domain.Entities;
using MiniStore.Domain.Pagination;

namespace MiniStore.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task AddProdutoAsync (Produto produto);
        PagedList<Produto> GetProdutos(ProdutosParameters produtosParameters);
        Task<bool> DeleteProdutoAsync(Guid produtoId);
    }
}
