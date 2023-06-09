
using MiniStore.Domain.Entities;
using MiniStore.Domain.Interfaces;
using MiniStore.Infra.Data.Context;

namespace MiniStore.Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MiniStoreDbContext _miniStoreDbContext;
        public ProdutoRepository(MiniStoreDbContext miniStoreDbContext)
        {
            _miniStoreDbContext = miniStoreDbContext;
        }

        public async Task AddProdutoAsync(Produto produto)
        {
           await _miniStoreDbContext.AddAsync(produto);
        }
    }
}
