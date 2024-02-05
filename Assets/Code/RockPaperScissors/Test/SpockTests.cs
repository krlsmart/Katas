using FluentAssertions;
using NUnit.Framework;
using RockPaperScissors.Domain;
using static RockPaperScissors.Domain.Game.Result;

namespace RockPaperScissors.Test
{
    public class SpockTests
    {
        [Test]
        public void Spock_vs_Scissors_SpockWins()
        {
            new Game().PlayRound(GesturesFactory.Spock, GesturesFactory.Scissors).Should().Be(Player1Win);
        }

        [Test]
        public void Spock_vs_Rock_SpockWins()
        {
            new Game().PlayRound(GesturesFactory.Spock, GesturesFactory.Rock).Should().Be(Player1Win);
        }

        [Test]
        public void Spock_vs_Paper_SpockLoses()
        {
            new Game().PlayRound(GesturesFactory.Spock, GesturesFactory.Paper).Should().Be(Player2Win);
        }
        
        [Test]
        public void Spock_vs_Lizard_SpockLoses()
        {
            new Game().PlayRound(GesturesFactory.Spock, GesturesFactory.Lizard).Should().Be(Player2Win);
        }

        [Test]
        public void Spock_vs_Spock_Draw()
        {
            new Game().PlayRound(GesturesFactory.Spock, GesturesFactory.Spock).Should().Be(Draw);
        }
    }
}
