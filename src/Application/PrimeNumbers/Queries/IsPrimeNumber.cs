namespace Primes.Application.PrimeNumbers.Queries;

using System.Numerics;
using MediatR;
public sealed record class IsPrimeNumber : IRequest<string>
{
    public required BigInteger Value { get; init; }
}
