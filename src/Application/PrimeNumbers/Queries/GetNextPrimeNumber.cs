namespace Primes.Application.PrimeNumbers.Queries;

using System.Numerics;
using MediatR;
public sealed record class GetNextPrimeNumber : IRequest<string>
{
    public required BigInteger After { get; init; }
}
