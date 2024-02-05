using RockPaperScissors.Domain;
using NUnit.Framework;
using FluentAssertions;
using static RockPaperScissors.Domain.Game.Result;
using static RockPaperScissors.Domain.Gesture;

namespace RockPaperScissors.Test
{
    public class ScissorsTests
    {
        [Test]
        public void Scissors_vs_Paper_ScissorsWin()
        {
            new Game().PlayRound(Scissors, Paper).Should().Be(Player1Win);
        }

        [Test]
        public void Scissors_vs_Lizard_ScissorsWin()
        {
            new Game().PlayRound(Scissors, Lizard).Should().Be(Player1Win);
        }

        [Test]
        public void Scissors_vs_Rock_ScissorsLose()
        {
            new Game().PlayRound(Scissors, Rock).Should().Be(Player2Win);
        }

        [Test]
        public void Scissors_vs_Scissors_Draw()
        {
            new Game().PlayRound(Scissors, Scissors).Should().Be(Draw);
        }
    }
}
