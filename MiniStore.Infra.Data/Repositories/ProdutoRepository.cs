using MiniStore.Domain.Entities;
using MiniStore.Domain.Interfaces;
using MiniStore.Infra.Data.Base;

namespace MiniStore.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto> , IProdutoRepository
    {

    }
}
