namespace Primes.Application.PrimeNumbers.Services;

using Microsoft.Extensions.Logging;
using Primes.Application.PrimeNumbers.Interfaces;

internal sealed class PrimesService(ILogger<PrimesService> logger) : IPrimesService
{
    public Task<string> GetNextPrimeAfterAsync(int after, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<string> IsPrimeNumberAsync(int value, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
