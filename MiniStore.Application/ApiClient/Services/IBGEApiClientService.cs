using Microsoft.Extensions.Options;
using MiniStore.Application.ApiClient.IBGEApi.Base;
using MiniStore.Application.ApiClient.Interfaces;
using MiniStore.Application.ApiClient.Models;
using MiniStore.Application.Extensions;

namespace MiniStore.Application.ApiClient.Services
{
    public class IBGEApiClientService : IIBGEApiClientService
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<IBGEApiOptions> _options;
        private readonly JsonDeserializer _jsonDeserializer;

        public IBGEApiClientService(HttpClient httpClient, 
            IOptions<IBGEApiOptions> options, 
            JsonDeserializer jsonDeserializer)
        {
            _httpClient = httpClient;
            _options = options;
            _jsonDeserializer = jsonDeserializer;
        }

        public async Task<List<Estado>> GetEstados()
        {
            var response = await _httpClient.GetAsync(_options.Value.BaseUrl);
            response.EnsureSuccessStatusCode();

            var estados = await _jsonDeserializer.DeserializeAsync<List<Estado>>(response);
            return estados;
        }
    }
}
