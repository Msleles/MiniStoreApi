using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniStore.Domain.Entities;
using MiniStore.Infra.Data.EntitiesConfiguration.Data;

namespace MiniStore.Infra.Data.EntitiesConfiguration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).HasMaxLength(50).IsRequired();
            builder.HasData(CategoriaDataSeeder.IniciarCategorias());
        }
    }
}
