using AdministrandoAluguelDeVeiculos.Application.Applications;
using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using Microsoft.Extensions.DependencyInjection;

namespace AdministrandoAluguelDeVeiculos.Application;

public static class  ApplicationModule
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICadastrarVeiculoApplication, CadastrarVeiculoApplication>();
        services.AddScoped<ICadastrarClienteApplication, CadastrarClienteApplication>();
        services.AddScoped<IListarTodosOsClientesApplication, ListarTodosOsClientesApplicationApplication>();
        services.AddScoped<IBuscarClientePorIdApplication, BuscarClienesPorIdApplication>();
        return services;
    }
}