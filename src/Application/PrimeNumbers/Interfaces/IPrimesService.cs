using System.Numerics;

namespace Primes.Application.PrimeNumbers.Interfaces;
public interface IPrimesService
{
    Task<string> GetNextPrimeAfterAsync(BigInteger after, CancellationToken cancellationToken = default);
    Task<string> IsPrimeNumberAsync(BigInteger value, CancellationToken cancellationToken = default);
}
