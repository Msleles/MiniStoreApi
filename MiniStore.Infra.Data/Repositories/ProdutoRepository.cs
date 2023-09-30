using Microsoft.IdentityModel.Tokens;
using MiniStore.Domain.Entities;
using MiniStore.Domain.Interfaces;
using MiniStore.Domain.Pagination;
using MiniStore.Infra.Data.Context;
using MiniStore.Infra.Data.Dapper.Interface;
using System.Runtime.Intrinsics.X86;


namespace MiniStore.Infra.Data.Repositories
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        private readonly MiniStoreDbContext _miniStoreDbContext;
        private readonly IDatabaseConnection _connection;
        public ProdutoRepository(MiniStoreDbContext miniStoreDbContext,
            IDatabaseConnection connection) : base(miniStoreDbContext)
        {
            _miniStoreDbContext = miniStoreDbContext;
            _connection = connection;
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

        public async Task<bool> DeleteProdutoAsync(Guid produtoId)
        {
            try
            {
                string deleteSql = "DELETE FROM Produtos WHERE Id = @ProdutoId";
                var parameters = new { ProdutoId = produtoId };
                int rowsAffected = _connection.Execute(deleteSql, parameters);

                bool isDeleted = rowsAffected > 0;
                return isDeleted;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
