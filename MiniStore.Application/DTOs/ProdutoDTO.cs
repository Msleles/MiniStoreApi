namespace MiniStore.Application.DTOs
{
    public class ProdutoDTO
    {
        public Guid Id { get; set; }
        public bool Status { get; set; }
        public DateTimeOffset DataCadastro { get; set; }
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public Guid CategoriaId { get; set; }
    }
}
