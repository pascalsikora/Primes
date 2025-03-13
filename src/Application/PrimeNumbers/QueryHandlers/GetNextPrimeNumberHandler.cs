namespace Primes.Application.PrimeNumbers.QueryHandlers;

using Microsoft.Extensions.Logging;
using Primes.Application.PrimeNumbers.Interfaces;
using Primes.Application.PrimeNumbers.Queries;

internal sealed class GetNextPrimeNumberHandler(ILogger<GetNextPrimeNumberHandler> logger, IPrimesService service) : MediatR.IRequestHandler<GetNextPrimeNumber, string>
{
    public async Task<string> Handle(GetNextPrimeNumber request, CancellationToken cancellationToken)
    {
        logger.LogInformation($"Get next prime number after '{request.After}' number");

        return await service.GetNextPrimeAfterAsync(request.After, cancellationToken);
    }
}
