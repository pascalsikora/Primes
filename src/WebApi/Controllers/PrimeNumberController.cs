namespace Primes.WebApi.Controllers;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using Primes.Application.Primes.Model;

[ApiController, Route("[controller]")]
public class PrimeNumberController(IMediator mediator) : ControllerBase
{
    [HttpGet("{value}", Name = "IsPrimeNumber")]
    public PrimeNumber Get(int value)
    {
        PrimeNumber primeNumber = new()
        {
            value = value,
        };

        return primeNumber;
    }

    [HttpGet("next-after/{value}", Name = "NextPrimeNumber")]
    public PrimeNumber GetNext([FromQuery] int value)
    {
        PrimeNumber primeNumber = new()
        {
            value = value,
        };

        return primeNumber;
    }
}
