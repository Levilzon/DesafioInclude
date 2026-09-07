using AdministrandoAluguelDeVeiculos.Middlewares;

namespace AdministrandoAluguelDeVeiculos.Extensions;

public static class MiddlewareExtensions
{
    public static IServiceCollection AddMiddleware(this IServiceCollection services)
    {
        services.AddTransient<GlobalExceptionHandler>();
        return services;
    }
}