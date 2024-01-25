using RockPaperScissors.Domain;
using NUnit.Framework;
using FluentAssertions;
using static RockPaperScissors.Domain.Game.Result;

namespace RockPaperScissors.Test
{
    public class RockTests
    {
        [Test]
        public void Rock_vs_Scissors_RockWin()
        {
            new Game().PlayRound(new Rock(), new Scissors()).Should().Be(Player1Win);
        }

        [Test]
        public void Rock_vs_Paper_RockLose()
        {
            new Game().PlayRound(new Rock(), new Paper()).Should().Be(Player2Win);
        }

        [Test]
        public void Rock_vs_Rock_Draw()
        {
            new Game().PlayRound(new Rock(), new Rock()).Should().Be(Draw);
        }
    }
}
