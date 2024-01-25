using RockPaperScissors.Domain;
using NUnit.Framework;
using FluentAssertions;

namespace RockPaperScissors.Test
{
    public class GameRulesTests
    {
        [Test]
        public void RockBeatsScissors()
        {
            var rock = Gesture.Rock();
            var scissors = Gesture.Scissors();

            var winner = new Game().Play(rock, scissors);

            winner.Should().Be(rock);
        }
    }
}
