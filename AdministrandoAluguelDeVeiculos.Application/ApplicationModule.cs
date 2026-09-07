using AdministrandoAluguelDeVeiculos.Application.Applications;
using AdministrandoAluguelDeVeiculos.Application.Notifications;
using AdministrandoAluguelDeVeiculos.Core.Interface.Application;
using AdministrandoAluguelDeVeiculos.Core.Interface.Notifications;
using Microsoft.Extensions.DependencyInjection;

namespace AdministrandoAluguelDeVeiculos.Application;

public static class  ApplicationModule
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ICadastrarVeiculoApplication, CadastrarVeiculoApplication>();
        services.AddScoped<ICadastrarClienteApplication, CadastrarClienteApplication>();
        services.AddScoped<IListarTodosOsClientesApplication, ListarTodosOsClientesApplicationApplication>();
        services.AddScoped<IBuscarClientePorIdApplication, BuscarClientesPorIdApplication>();
        services.AddScoped<IClienteAtualizarApplication, ClienteAtualizarApplication>();
        services.AddScoped<INotificador, Notificador>();
        return services;
    }
}