using MiniStore.Domain.Base;

namespace MiniStore.Domain.Entities
{
    public class Produto : EntityBase
    {
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
