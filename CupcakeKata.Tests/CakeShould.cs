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
        sut.Price.Should().BeApproximately(1.1f, 0.01f);
    }

    [Test]
    public void HaveChocolateAndPeanutToppings()
    {
        var sut = new Peanut(new Chocolate(new Cupcake()));
        
        sut.Name.Should().Be("Cupcake with Chocolate and Peanut");
        sut.Price.Should().BeApproximately(1.3f, 0.01f);
    }
}