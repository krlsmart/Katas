using RockPaperScissors.Domain;
using NUnit.Framework;
using FluentAssertions;
using static RockPaperScissors.Domain.Game.Result;

namespace RockPaperScissors.Test
{
    public class PaperTests
    {
        [Test]
        public void Paper_vs_Rock_PaperWin()
        {
            new Game().PlayRound(new Paper(), new Rock()).Should().Be(Player1Win);
        }

        [Test]
        public void Paper_vs_Scissors_PaperLose()
        {
            new Game().PlayRound(new Paper(), new Scissors()).Should().Be(Player2Win);
        }

        [Test]
        public void Paper_vs_Paper_Draw()
        {
            new Game().PlayRound(new Paper(), new Paper()).Should().Be(Draw);
        }
    }
}
