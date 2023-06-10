using System.Text.Json.Serialization;
using System.Text.Json;

namespace MiniStore.Application.Extensions
{
    public class JsonDeserializer
    {
        private readonly JsonSerializerOptions _options;

        public JsonDeserializer()
        {
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                Converters =
            {
                new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
            }
            };
        }

        public async Task<T> DeserializeAsync<T>(HttpResponseMessage response)
        {
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<T>(json, _options);
            return result;
        }
    }
}
