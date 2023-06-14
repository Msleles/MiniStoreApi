using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace MiniStore.Infra.Data.Identity.Jwt
{
    public static class JwtConfiguration
    {
        private static string? key;
        private static string? audience;
        private static string? Issuer;

        public static IServiceCollection AddAuthenticationJwtBearer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions<JwtConfigurationOptions>()
                .Configure(options =>
                {
                    options.Key = configuration?.GetValue<string>("Jwt:Key")
                    ?? throw new InvalidOperationException("Jwt Key Api must be set.");

                    options.Audience = configuration?.GetValue<string>("TokenConfiguration:Audience")
                    ?? throw new InvalidOperationException("TokenConfiguration Audience must be set.");

                    options.Issuer = configuration?.GetValue<string>("TokenConfiguration:Issuer")
                    ?? throw new InvalidOperationException("TokenConfiguration Issuer must be set.");

                    options.ExpireHours = configuration?.GetValue<int>("TokenConfiguration:ExpireHours")
                    ?? throw new InvalidOperationException("TokenConfiguration ExpireHours must be set.");

                    key = options.Key;
                    audience = options.Audience;
                    Issuer = options.Issuer;
                });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).
                AddJwtBearer(options =>
                 options.TokenValidationParameters = new TokenValidationParameters
                 {
                     ValidateIssuer = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidAudience = audience,
                     ValidIssuer = Issuer,
                     ValidateIssuerSigningKey = true,
                     IssuerSigningKey = new SymmetricSecurityKey
                     (
                         Encoding.UTF8.GetBytes(key
                     ))
                 });

            return services;
        }
    }
}
