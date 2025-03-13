namespace Primes.Application.PrimeNumbers.QueryHandlers;

using Microsoft.Extensions.Logging;
using Primes.Application.PrimeNumbers.Interfaces;
using Primes.Application.PrimeNumbers.Queries;

internal sealed class IsPrimeNumberHandler(ILogger<IsPrimeNumberHandler> logger, IPrimesService service) : MediatR.IRequestHandler<IsPrimeNumber, string>
{
    public async Task<string> Handle(IsPrimeNumber request, CancellationToken cancellationToken)
    {
        logger.LogInformation($"Checking if '{request.Value}' is a prime number.");

        return await service.IsPrimeNumberAsync(request.Value, cancellationToken);
    }
}
