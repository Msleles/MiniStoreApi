namespace MiniStore.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

       Task<bool> Commit();
       IProdutoRepository  ProdutoRepository{ get; }
    }
}
