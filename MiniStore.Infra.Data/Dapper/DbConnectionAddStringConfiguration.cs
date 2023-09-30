using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MiniStore.Infra.Data.Dapper
{
    public static class DbConnectionAddStringConfiguration
    {
        public static void AddConnectionString(this IServiceCollection services, IConfiguration configuration = null)
        {
            services.AddOptions<DataBaseConnectionStringOptions>()
               .Configure(options =>
               {
                   options.ConnectionString = configuration?.GetValue<string>("ConnectionStrings:DefaultConnection")
                   ?? throw new InvalidOperationException("Database connection is not configured.");
               });
        }
    }
}
