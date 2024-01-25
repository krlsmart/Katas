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
            var rock = new Rock();
            var scissors = new Scissors();

            var result = new Game().PlayRound(rock, scissors);

            result.Should().Be(Player1Win);
        }

        [Test]
        public void Rock_vs_Paper_PaperWin()
        {
            var rock = new Rock();
            var paper = new Paper();

            var result = new Game().PlayRound(rock, paper);

            result.Should().Be(Player2Win);
        }
    }
}
