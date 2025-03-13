namespace Primes.WebApi.Controllers;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using Primes.Application.PrimeNumbers.Queries;

[ApiController, Route("[controller]")]
public class PrimeNumberController(IMediator mediator) : ControllerBase
{
    [HttpGet("next-after/{value}", Name = "GetNextPrimeNumber")]
    public async Task<string> GetNextPrimeNumberAsync([FromQuery] int after, CancellationToken cancellationToken)
    {
        var query = new GetNextPrimeNumber
        {
            After = after,
        };

        var result = await mediator.Send(query, cancellationToken);

        return result;
    }

    [HttpGet("{value}", Name = "IsPrimeNumber")]
    public async Task<string> IsPrimeNumberAsync(int value, CancellationToken cancellationToken)
    {
        var query = new IsPrimeNumber
        {
            Value = value,
        };

        var result = await mediator.Send(query, cancellationToken);

        return result;
    }
}
