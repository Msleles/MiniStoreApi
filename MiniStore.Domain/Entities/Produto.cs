using MiniStore.Domain.Base;

namespace MiniStore.Domain.Entities
{
    public class Produto : EntityBase
    {
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
