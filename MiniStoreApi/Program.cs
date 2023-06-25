using Hangfire;
using Microsoft.OpenApi.Models;
using MiniStore.Application.ApiClient.IBGEApi.Base;
using MiniStore.Application.SendGrid;
using MiniStore.Infra.Data.Identity.Jwt;
using MiniStore.Infra.Data.Mappings;
using MiniStore.Infra.IoC;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAuthenticationJwtBearer(builder.Configuration);
builder.Services.AddSendGridConfiguration(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);
AutoMapperConfiguration.AddAutoMapper(builder.Services);
builder.Services.AddIBGEApiConfiguration(builder.Configuration);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();



builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mini Store API", Version = "v1" });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Insira o token JWT, exemplo: Bearer {seu token}",
        Name = "Authorization",
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mini Store V1");
    });
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.UseHangfireDashboard();
app.Run();
