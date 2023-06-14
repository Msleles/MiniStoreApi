using MiniStore.Domain.Account.Models;
using MiniStore.Domain.Models;

namespace MiniStore.Domain.Account
{
    public interface IAuthenticate
    {
        Task<UsuarioToken> Authenticate(string email, string password);
        Task<bool> RegisterUser(string email, string password);
        UsuarioToken GerarToken(Usuario usuario);
        Task Logout();
    }
}
