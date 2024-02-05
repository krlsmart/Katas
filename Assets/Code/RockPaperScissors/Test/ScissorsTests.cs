using RockPaperScissors.Domain;
using NUnit.Framework;
using FluentAssertions;
using static RockPaperScissors.Domain.Game.Result;

namespace RockPaperScissors.Test
{
    public class ScissorsTests
    {
        [Test]
        public void Scissors_vs_Paper_ScissorsWin()
        {
            new Game().PlayRound(GesturesFactory.Scissors, GesturesFactory.Paper).Should().Be(Player1Win);
        }

        [Test]
        public void Scissors_vs_Lizard_ScissorsWin()
        {
            new Game().PlayRound(GesturesFactory.Scissors, GesturesFactory.Lizard).Should().Be(Player1Win);
        }

        [Test]
        public void Scissors_vs_Rock_ScissorsLose()
        {
            new Game().PlayRound(GesturesFactory.Scissors, GesturesFactory.Rock).Should().Be(Player2Win);
        }

        [Test]
        public void Scissors_vs_Scissors_Draw()
        {
            new Game().PlayRound(GesturesFactory.Scissors, GesturesFactory.Scissors).Should().Be(Draw);
        }
    }
}
