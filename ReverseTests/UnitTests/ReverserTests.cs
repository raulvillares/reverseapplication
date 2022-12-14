using NUnit.Framework;
using FluentAssertions;
using ReverseApp;

namespace ReverseTests.UnitTests;

[TestFixture]
public class ReverserTests
{
    [TestCase("a", "a")]
    [TestCase("hello", "olleh")]
    [TestCase("hello world", "dlrow olleh")]
    public void Reverse_ShouldReverseGivenString(string text, string expected)
    {
        var reverser = new Reverser();
        
        var result = reverser.Reverse(text);
        
        result.Should().Be(expected);
    }

    [Test]
    public void Reverse_ShouldReturnEmptyString_WhenGivenNull()
    {
        var reverser = new Reverser();
        
        var result = reverser.Reverse(null);
        
        result.Should().BeEmpty();
    }

    [Test]
    public void Reverse_ShouldReturnEmptyString_WhenGivenEmptyString()
    {
        var reverser = new Reverser();
        
        var result = reverser.Reverse("");
        
        result.Should().BeEmpty();
    }
}
