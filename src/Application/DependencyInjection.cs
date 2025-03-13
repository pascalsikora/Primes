namespace Primes.Application;

using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Primes.Application.Battle;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

        services.AddPrimesService();

        return services;
    }
}