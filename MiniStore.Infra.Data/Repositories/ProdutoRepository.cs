
using MiniStore.Domain.Entities;
using MiniStore.Domain.Interfaces;
using MiniStore.Domain.Pagination;
using MiniStore.Infra.Data.Context;

namespace MiniStore.Infra.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        private readonly MiniStoreDbContext _miniStoreDbContext;
        public ProdutoRepository(MiniStoreDbContext miniStoreDbContext) : base(miniStoreDbContext)
        {
            _miniStoreDbContext = miniStoreDbContext;
        }

        public async Task AddProdutoAsync(Produto produto)
        {
           await _miniStoreDbContext.AddAsync(produto);
        }

        public PagedList<Produto> GetProdutos(ProdutosParameters produtosParameters)
        {
            return PagedList<Produto>.ToPagedList(Get().OrderBy(on => on.Id),
                 produtosParameters.PageNumber, produtosParameters.PageSize);
        }
    }
}
