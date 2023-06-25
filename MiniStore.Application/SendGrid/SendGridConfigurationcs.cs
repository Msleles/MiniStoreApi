using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SendGrid;

namespace MiniStore.Application.SendGrid
{
    public static class SendGridConfigurationcs
    {
        public static IServiceCollection AddSendGridConfiguration(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddOptions<SendGridOptions>()
            .Configure(options =>
            {
                options.ApiKey = configuration?.GetValue<string>("SendGridSettings:ApiKey") ?? throw new InvalidOperationException("SendGrid API Key must be set.");
                options.Email = configuration?.GetValue<string>("SendGridSettings:Email") ?? throw new InvalidOperationException("SendGrid API Email must be set.");
                options.Nome = configuration?.GetValue<string>("SendGridSettings:Nome") ?? throw new InvalidOperationException("SendGrid API Nome must be set.");

            });

            services.AddScoped<ISendGridClient, SendGridClient>(provider => new SendGridClient(configuration.GetValue<string>("SendGridSettings:ApiKey")));

            return services;
        }
    }
}
