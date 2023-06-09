using MiniStore.Application.DTOs;

namespace MiniStore.Application.Interfaces
{
    public interface IProdutoService
    {
        Task<ProdutoDTO> Novo(ProdutoDTO produtoDTO);
    }
}
