using MiniStore.Domain.Entities;
using MiniStore.Domain.Interfaces;
using MiniStore.Infra.Data.Base;
using MiniStore.Infra.Data.Context;

namespace MiniStore.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto> , IProdutoRepository
    {
        private readonly MiniStoreDbContext _miniStoreDbContext;
        public ProdutoRepository(MiniStoreDbContext miniStoreDbContext)
        {
            _miniStoreDbContext = miniStoreDbContext;
        }
    }
}
