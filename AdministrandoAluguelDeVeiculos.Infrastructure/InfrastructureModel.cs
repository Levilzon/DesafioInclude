using AdministrandoAluguelDeVeiculos.Core.Interface.Repositories;
using AdministrandoAluguelDeVeiculos.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AdministrandoAluguelDeVeiculos.Infrastructure;

public static class InfrastructureModel
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<AdministrandoAluguelDeVeiculosContext>(p =>
            p.UseNpgsql("Server=localhost;Port=5432;Database=administrando_aluguel_veiculos;User Id=postgres;Password=2445Cem3"));
        
        services.AddScoped<DbContext, AdministrandoAluguelDeVeiculosContext>();
        services.AddScoped<IVeiculosRepository, VeiculoRepository>();

        return services;
    }
}