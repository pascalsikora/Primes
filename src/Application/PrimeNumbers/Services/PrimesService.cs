namespace Primes.Application.PrimeNumbers.Services;

using System.Numerics;
using Microsoft.Extensions.Logging;
using Primes.Application.PrimeNumbers.Interfaces;
using Primes.Application.PrimeNumbers.Queries;

internal sealed class PrimesService(ILogger<PrimesService> logger) : IPrimesService
{
    private readonly ILogger<PrimesService> logger = logger;

    public Task<string> GetNextPrimeAfterAsync(BigInteger after, CancellationToken cancellationToken = default)
    {
        BigInteger nextPrimeNumber = 0;                         
        BigInteger current = after;
        do
        {
            current++;
            if (this.IsPrimeNumber(current))
            {
                nextPrimeNumber = current;
            }
        } while (nextPrimeNumber == 0);
        
        var printResult = $"Next prime number after {after} is {nextPrimeNumber}";

        this.logger.LogInformation(printResult);

        return Task.FromResult(printResult);
    }

    public Task<string> IsPrimeNumberAsync(BigInteger  value, CancellationToken cancellationToken = default)
    {

        var isPrime = this.IsPrimeNumber(value);
        var result = (isPrime) ? "Is prime number" : "Is not a prime number";
        var printResult = $"Number {value}: {result}";
        
        this.logger.LogInformation(printResult);

        return Task.FromResult(printResult);
    }

    public bool IsPrimeNumber(BigInteger  value)
    {
        if (value < 2)
        {
            return false;
        }

        for (BigInteger  i = 2; i * i <= value; i++)
        {
            if (value % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
