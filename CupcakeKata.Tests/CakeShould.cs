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

    [Test]
    public void HaveChocolateTopping()
    {
        var sut = new Chocolate(new Cupcake());

        sut.Name.Should().Be("Cupcake with Chocolate");
        sut.Price.Should().Be(1.1f);
    }
}