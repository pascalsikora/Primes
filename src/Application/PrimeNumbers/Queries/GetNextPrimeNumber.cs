namespace Primes.Application.PrimeNumbers.Queries;

public sealed record class GetNextPrimeNumber : MediatR.IRequest<string>
{
    public required int After { get; init; }
}
