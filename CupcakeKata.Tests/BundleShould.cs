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
        sut.Price.Should().Be(0.9f);
    }
}