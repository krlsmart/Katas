using FluentAssertions;
using NUnit.Framework;
using System.Linq;
using TradingCards.Domain;

namespace TradingCards.Test
{
    public class PlayerDeckTests
    {
        [Test]
        public void StartingDeck()
        {
            var sut = DeckFactory.StartingDeck();

            sut.Cards.Count().Should().Be(30);
        }
    }
}
