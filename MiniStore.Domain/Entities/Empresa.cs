namespace MiniStore.Domain.Entities
{
    public class Empresa
    {
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? CEP { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
