using FluentAssertions;
using NUnit.Framework;
using System.Linq;
using static TradingCards.Domain.DeckFactory;

namespace TradingCards.Test
{
    public class PlayerDeckTests
    {
        [Test]
        public void StartingDeck_HasCorrectSize()
        {
            var sut = StartingDeck();

            sut.Cards.Count().Should().Be(StartingDeckSize);
        }

        [Test]
        public void StartingDeck_HasCorrectDistribution()
        {
            var sut = StartingDeck();

            sut.Cards.Where(c => c.ManaCost == 0).Count().Should().Be(StartingDeckDistribution[0]);
            sut.Cards.Where(c => c.ManaCost == 1).Count().Should().Be(StartingDeckDistribution[1]);
            sut.Cards.Where(c => c.ManaCost == 2).Count().Should().Be(StartingDeckDistribution[2]);
            sut.Cards.Where(c => c.ManaCost == 3).Count().Should().Be(StartingDeckDistribution[3]);
            sut.Cards.Where(c => c.ManaCost == 4).Count().Should().Be(StartingDeckDistribution[4]);
            sut.Cards.Where(c => c.ManaCost == 5).Count().Should().Be(StartingDeckDistribution[5]);
            sut.Cards.Where(c => c.ManaCost == 6).Count().Should().Be(StartingDeckDistribution[6]);
            sut.Cards.Where(c => c.ManaCost == 7).Count().Should().Be(StartingDeckDistribution[7]);
            sut.Cards.Where(c => c.ManaCost == 8).Count().Should().Be(StartingDeckDistribution[8]);
        }
    }
}
