using RockPaperScissors.Domain;
using NUnit.Framework;
using FluentAssertions;
using static RockPaperScissors.Domain.Game.Result;
using static RockPaperScissors.Domain.Gesture;

namespace RockPaperScissors.Test
{
    public class RockTests
    {
        [Test]
        public void Rock_vs_Scissors_RockWin()
        {
            new Game().PlayRound(Rock, Scissors).Should().Be(Player1Win);
        }

        [Test]
        public void Rock_vs_Paper_RockLose()
        {
            new Game().PlayRound(Rock, Paper).Should().Be(Player2Win);
        }

        [Test]
        public void Rock_vs_Rock_Draw()
        {
            new Game().PlayRound(Rock, Rock).Should().Be(Draw);
        }
    }
}
