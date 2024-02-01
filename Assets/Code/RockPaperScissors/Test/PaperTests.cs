using RockPaperScissors.Domain;
using NUnit.Framework;
using FluentAssertions;
using static RockPaperScissors.Domain.Game.Result;
using static RockPaperScissors.Domain.Gesture;

namespace RockPaperScissors.Test
{
    public class PaperTests
    {
        [Test]
        public void Paper_vs_Rock_PaperWin()
        {
            new Game().PlayRound(Paper, Rock).Should().Be(Player1Win);
        }

        [Test]
        public void Paper_vs_Scissors_PaperLose()
        {
            new Game().PlayRound(Paper, Scissors).Should().Be(Player2Win);
        }

        [Test]
        public void Paper_vs_Paper_Draw()
        {
            new Game().PlayRound(Paper, Paper).Should().Be(Draw);
        }
    }
}
