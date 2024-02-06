using FluentAssertions;
using NUnit.Framework;
using TradingCards.Domain;

public class PlayerTests
{
    [Test]
    public void Player_ReceivesDamage()
    {
        var sut = new Player();

        var startingHealth = sut.Health;
        sut.ReceiveDamage(4);

        sut.Health.Should().Be(startingHealth-4);
    }
}
