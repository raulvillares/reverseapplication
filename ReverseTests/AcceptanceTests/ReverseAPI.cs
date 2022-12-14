using System.Net;
using NUnit.Framework;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

namespace ReverseTests.AcceptanceTests;

[TestFixture]
public class ReverseAPI
{
    [Test]
    public async Task GET_reverse_text()
    {
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();
        
        var response = await client.GetAsync("/reverse?text=hello world");
        
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        response.Content.ReadAsStringAsync().Result.Should().Be("dlrow olleh");
    }
}