using RockPaperScissors.Domain;
using NUnit.Framework;
using FluentAssertions;
using static RockPaperScissors.Domain.Game.Result;

namespace RockPaperScissors.Test
{
    public class GameRulesTests
    {
        [Test]
        public void Rock_vs_Scissors_RockWin()
        {
            var rock = Gesture.Rock();
            var scissors = Gesture.Scissors();

            var result = new Game().PlayRound(rock, scissors);

            result.Should().Be(Player1Win);
        }

        [Test]
        public void Rock_vs_Paper_PaperWin()
        {
            var rock = Gesture.Rock();
            var paper = Gesture.Paper();

            var result = new Game().PlayRound(rock, paper);

            result.Should().Be(Player2Win);
        }
    }
}
