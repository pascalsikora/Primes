namespace Primes.Application.PrimeNumbers.Interfaces;

public interface IPrimesService
{
    Task<string> GetNextPrimeAfterAsync(int after, CancellationToken cancellationToken = default);
    Task<string> IsPrimeNumberAsync(int value, CancellationToken cancellationToken = default);
}
