namespace Primes.WebApi.IntegrationTests;

using System.Net;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

[TestClass]
public sealed class BattleTests
{
    private static HttpClient? client;

    [ClassInitialize]
    public static void Initialize(TestContext context)
    {
        var factory = new WebApplicationFactory<Program>();
        client = factory.CreateClient();
    }

    [TestMethod]
    public async Task Get_Endpoint_CorrectPrime()
    {
        // Arrange

        // Act
        var response = await client!.GetAsync("/PrimeNumber/17");

        // Assert
        response.StatusCode.Should()
            .Be(HttpStatusCode.OK)
            ;
        response.Content.Headers.ContentType?.ToString().Should()
            .Be("text/plain; charset=utf-8")
            ;

        var content = await response.Content.ReadAsStringAsync();
        content.Should()
            .Be("Number 17: Is prime number")
            ;
    }

    [TestMethod]
    public async Task Get_Endpoint_NextPrime()
    {
        // Arrange

        // Act
        var response = await client!.GetAsync("/PrimeNumber/next-after/17");

        // Assert
        response.StatusCode.Should()
            .Be(HttpStatusCode.OK)
            ;
        response.Content.Headers.ContentType?.ToString().Should()
            .Be("text/plain; charset=utf-8")
            ;

        var content = await response.Content.ReadAsStringAsync();
        content.Should()
            .Be("Next prime number after 17 is 19")
            ;
    }

}
