using MiniStore.Domain.Interfaces;
using MiniStore.Infra.Data.Context;
using MiniStore.Infra.Data.Repositories;
using System.Security.Cryptography.X509Certificates;

namespace MiniStore.Infra.Data.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MiniStoreDbContext _miniStoreDbContext;

        public UnitOfWork(MiniStoreDbContext miniStoreDbContext)
        {
            _miniStoreDbContext = miniStoreDbContext;
        }

        private IProdutoRepository _produtoRepository;
        public IProdutoRepository ProdutoRepository
        {
            get => _produtoRepository ?? (_produtoRepository = new ProdutoRepository(_miniStoreDbContext));
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
