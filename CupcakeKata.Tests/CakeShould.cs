using CupcakeKata.Domain;
using FluentAssertions;

namespace CupcakeKata.Tests;

public class CakeShould
{
    [Test]
    public void Be_ACupcake()
    {
        var sut = new Cupcake();
        
        sut.Name.Should().Be("Cupcake");
        sut.Price.Should().Be(1f);
    }
}