using MiniStore.Domain.Interfaces;
using MiniStore.Infra.Data.Context;

namespace MiniStore.Infra.Data.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MiniStoreDbContext _miniStoreDbContext;

        public UnitOfWork(MiniStoreDbContext miniStoreDbContext)
        {
            _miniStoreDbContext = miniStoreDbContext;
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
