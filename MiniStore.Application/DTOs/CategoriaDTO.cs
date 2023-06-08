namespace MiniStore.Application.DTOs
{
    public class CategoriaDTO
    {
        public Guid Id { get; set; }
        public bool Status { get; set; }
        public DateTimeOffset DataCadastro { get; set; }
        public string? Nome { get; set; }
    }
}
