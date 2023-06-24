using Hangfire;
using Microsoft.Extensions.DependencyInjection;


namespace MiniStore.Infra.Data.HangFireConfigurations
{
    public static class HangFireConfiguration
    {
        public static void AddHangfireJob(this IServiceCollection services, string connectionString)
        {
            services.AddHangfire(config =>
            {
                config.UseSqlServerStorage(connectionString);
            });

            services.AddHangfireServer();
        }
    }
}