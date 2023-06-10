using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiniStore.Application.ApiClient.Interfaces;
using MiniStore.Application.ApiClient.Services;
using MiniStore.Application.Interfaces;
using MiniStore.Application.Interfaces.Notificador;
using MiniStore.Application.Services;
using MiniStore.Domain.Interfaces;
using MiniStore.Infra.Data.Base;
using MiniStore.Infra.Data.Context;
using MiniStore.Infra.Data.Repositories;


namespace MiniStore.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Database connection
            services.AddDbContext<MiniStoreDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
             ), b => b.MigrationsAssembly(typeof(MiniStoreDbContext).Assembly.FullName)));

            // Repositorios
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();

            // Serviços
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<INotificationService, NotificationService>();

            // Serviços externos
            services.AddHttpClient<IIBGEApiClientService, IBGEApiClientService>();

            return services;
        }
    }
}
