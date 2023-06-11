using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiniStore.Domain.Entities;
using MiniStore.Infra.Data.Identity;

namespace MiniStore.Infra.Data.Context
{
    public class MiniStoreDbContext : IdentityDbContext<ApplicationUser>
    {
        public MiniStoreDbContext(DbContextOptions<MiniStoreDbContext> options): base(options) { }

        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(MiniStoreDbContext).Assembly);
        }
    }
}
