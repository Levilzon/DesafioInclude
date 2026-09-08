using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using AdministrandoAluguelDeVeiculos.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AdministrandoAluguelDeVeiculos.Infrastructure;

public static class InfrastructureModel
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<AdministrandoAluguelDeVeiculosContext>(p =>
            p.UseNpgsql("Server=localhost;Port=5432;Database=administrando_aluguel_veiculos;User Id={usuario};Password={senha}"));
        
        services.AddScoped<DbContext, AdministrandoAluguelDeVeiculosContext>();
        services.AddScoped<IVeiculosRepository, VeiculoRepository>();
        services.AddScoped<IClienteRepository, ClienteRepository>();
        services.AddScoped<IAluguelRepository, AluguelRepository>();
        return services;
    }
}