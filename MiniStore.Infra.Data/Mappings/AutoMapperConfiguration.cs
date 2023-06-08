using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace MiniStore.Infra.Data.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void AddAutoMapper(IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
