namespace Primes.Application.Battle;

using Primes.Application.PrimeNumbers.Interfaces;
using Primes.Application.PrimeNumbers.Services;
using Microsoft.Extensions.DependencyInjection;

internal static class DependencyInjection
{
    public static IServiceCollection AddPrimesService(this IServiceCollection services)
    {
        services.AddSingleton<IPrimesService, PrimesService>();

        return services;
    }
}
