using FluentAssertions;
using NUnit.Framework;
using RockPaperScissors.Domain;
using static RockPaperScissors.Domain.Game.Result;

namespace RockPaperScissors.Test
{
    public class LizardTests
    {
        [Test]
        public void Lizard_vs_Paper_LizardWins()
        {
            new Game().PlayRound(GesturesFactory.Lizard, GesturesFactory.Paper).Should().Be(Player1Win);
        }
        
        [Test]
        public void Lizard_vs_Spock_LizardWins()
        {
            new Game().PlayRound(GesturesFactory.Lizard, GesturesFactory.Spock).Should().Be(Player1Win);
        }

        [Test]
        public void Lizard_vs_Scissors_LizardLoses()
        {
            new Game().PlayRound(GesturesFactory.Lizard, GesturesFactory.Scissors).Should().Be(Player2Win);
        }

        [Test]
        public void Lizard_vs_Rock_LizardLoses()
        {
            new Game().PlayRound(GesturesFactory.Lizard, GesturesFactory.Rock).Should().Be(Player2Win);
        }

        [Test]
        public void Lizard_vs_Lizard_Draw()
        {
            new Game().PlayRound(GesturesFactory.Lizard, GesturesFactory.Lizard).Should().Be(Draw);
        }
    }
}
