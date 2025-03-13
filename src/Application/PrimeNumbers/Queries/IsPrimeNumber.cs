namespace Primes.Application.PrimeNumbers.Queries;

public sealed record class IsPrimeNumber : MediatR.IRequest<string>
{
    public required int Value { get; init; }
}
