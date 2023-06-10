using MiniStore.Application.ApiClient.Models;

namespace MiniStore.Application.ApiClient.Interfaces
{
    public interface IIBGEApiClientService
    {
        Task<List<Estado>> GetEstados();
    }
}
