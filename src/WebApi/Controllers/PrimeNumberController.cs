namespace Primes.WebApi.Controllers;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using Primes.Application.PrimeNumbers.Queries;

[ApiController, Route("[controller]")]
public class PrimeNumberController(IMediator mediator) : ControllerBase
{
    [HttpGet("next-after/{after}", Name = "GetNextPrimeNumber")]
    public async Task<string> GetNextPrimeNumberAsync(Int128 after, CancellationToken cancellationToken)
    {
        var query = new GetNextPrimeNumber
        {
            After = after,
        };

        var result = await mediator.Send(query, cancellationToken);

        return result;
    }

    [HttpGet("{value}", Name = "IsPrimeNumber")]
    public async Task<string> IsPrimeNumberAsync(Int128 value, CancellationToken cancellationToken)
    {
        var query = new IsPrimeNumber
        {
            Value = value,
        };

        var result = await mediator.Send(query, cancellationToken);

        return result;
    }
}
