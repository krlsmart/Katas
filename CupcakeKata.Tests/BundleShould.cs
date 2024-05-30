using CupcakeKata.Domain;
using FluentAssertions;

namespace CupcakeKata.Tests;

public class BundleShould
{
    [Test]
    public void ShouldContainACake()
    {
        var sut = new Bundle(new Cupcake());

        sut.Name.Should().Be("Bundle with 1 Cupcake");
        sut.Price.Should().BeApproximately(0.9f, 0.01f);
    }
    
    [Test]
    public void ShouldContainMultipleCakes()
    {
        var sut = new Bundle(new Cupcake(), new Cookie());

        sut.Name.Should().Be("Bundle with 1 Cupcake and 1 Cookie");
        sut.Price.Should().BeApproximately(2.7f, 0.01f);
    }

    [Test]
    public void ShouldContainOtherBundles()
    {
        var sut = new Bundle(new Cookie(), new Bundle(new Cupcake(), new Cookie()));
        
        sut.Name.Should().Be("Bundle with 1 Cookie and 1 Bundle with 1 Cupcake and 1 Cookie");
        sut.Price.Should().BeApproximately(4.23f, 0.01f);
    }
}