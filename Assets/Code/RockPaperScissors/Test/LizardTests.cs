using FluentAssertions;
using NUnit.Framework;
using RockPaperScissors.Domain;
using static RockPaperScissors.Domain.Game.Result;
using static RockPaperScissors.Domain.Gesture;

namespace RockPaperScissors.Test
{
    public class LizardTests
    {
        [Test]
        public void Lizard_vs_Paper_LizardWins()
        {
            new Game().PlayRound(Lizard, Paper).Should().Be(Player1Win);
        }

        [Test]
        public void Lizard_vs_Scissors_LizardLoses()
        {
            new Game().PlayRound(Lizard, Scissors).Should().Be(Player2Win);
        }

        [Test]
        public void Lizard_vs_Rock_LizardLoses()
        {
            new Game().PlayRound(Lizard, Rock).Should().Be(Player2Win);
        }

        [Test]
        public void Lizard_vs_Lizard_Draw()
        {
            new Game().PlayRound(Lizard, Lizard).Should().Be(Draw);
        }
    }
}
