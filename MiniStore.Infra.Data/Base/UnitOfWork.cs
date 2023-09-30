using MiniStore.Domain.Interfaces;
using MiniStore.Infra.Data.Context;
using MiniStore.Infra.Data.Dapper.Interface;
using MiniStore.Infra.Data.Repositories;

namespace MiniStore.Infra.Data.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MiniStoreDbContext _miniStoreDbContext;
        private readonly IDatabaseConnection _connection;

        public UnitOfWork(MiniStoreDbContext miniStoreDbContext, IDatabaseConnection connection)
        {
            _miniStoreDbContext = miniStoreDbContext;
            _connection = connection;
        }

        private IProdutoRepository? _produtoRepository;
        public IProdutoRepository ProdutoRepository
        {
            get => _produtoRepository ?? (_produtoRepository = new ProdutoRepository(_miniStoreDbContext, _connection));
        }

        public async Task<bool> Commit()
        {
            return await _miniStoreDbContext.SaveChangesAsync() > 0;
        }

        public void Dispose()
        {
            _miniStoreDbContext?.Dispose();
        }
    }
}
