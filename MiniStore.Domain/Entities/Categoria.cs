using MiniStore.Domain.Base;

namespace MiniStore.Domain.Entities
{
    public class Categoria : EntityBase
    {
        public string? Nome { get; set; }
        public ICollection<Produto>? Produtos { get; set; }
    }
}
