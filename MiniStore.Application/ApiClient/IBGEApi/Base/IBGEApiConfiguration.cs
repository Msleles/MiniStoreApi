using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace MiniStore.Application.ApiClient.IBGEApi.Base
{
    public static class IBGEApiConfiguration
    {
        public static void AddIBGEApiConfiguration(this IServiceCollection services, IConfiguration configuration = null)
        {
            services.AddOptions<IBGEApiOptions>()
                .Configure(options =>
                {
                    options.BaseUrl = configuration?.GetValue<string>("IBGEApi:BaseUrl") 
                    ?? throw new InvalidOperationException("IBGE API BaseAddress must be set.");
                });
        }
    }
}
