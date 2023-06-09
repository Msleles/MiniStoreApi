using MiniStore.Application.DTOs;
using MiniStore.Domain.Pagination;

namespace MiniStore.Application.Interfaces
{
    public interface IProdutoService
    {
        Task<ProdutoDTO> Novo(ProdutoDTO produtoDTO);
        PagedList<ProdutoDTO> GetProdutos(ProdutosParameters produtosParameters);
    }
}
