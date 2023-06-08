using Microsoft.EntityFrameworkCore;
using MiniStore.Domain.Entities;

namespace MiniStore.Infra.Data.Context
{
    public class MiniStoreDbContext : DbContext
    {
        public MiniStoreDbContext(DbContextOptions<MiniStoreDbContext> options): base(options) { }

        public DbSet<Produto>? Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(MiniStoreDbContext).Assembly);
        }
    }
}
