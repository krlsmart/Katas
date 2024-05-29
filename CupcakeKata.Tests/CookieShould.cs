using CupcakeKata.Domain;
using FluentAssertions;

namespace CupcakeKata.Tests;

public class CookieShould
{
    [Test]
    public void Be_ACookie()
    {
        var sut = new Cookie();
        
        sut.Name.Should().Be("Cookie");
        sut.Price.Should().Be(2f);
    }
    
    [Test]
    public void HaveChocolateTopping()
    {
        var sut = new Chocolate(new Cookie());

        sut.Name.Should().Be("Cookie with Chocolate");
        sut.Price.Should().BeApproximately(2.1f, 0.01f);
    }
    
    [Test]
    public void HaveToppingsInAnyOrder()
    {
        var sut = new Peanut(new Chocolate(new Peanut(new Cookie())));
        
        sut.Name.Should().Be("Cookie with Peanut and Chocolate and Peanut");
        sut.Price.Should().BeApproximately(2.5f, 0.01f);
    }
}