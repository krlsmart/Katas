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
            new Game().PlayRound(Gesture_NEW.Scissors, Gesture_NEW.Paper).Should().Be(Player1Win);
        }

        [Test]
        public void Scissors_vs_Rock_ScissorsLose()
        {
            new Game().PlayRound(Gesture_NEW.Scissors, Gesture_NEW.Rock).Should().Be(Player2Win);
        }

        [Test]
        public void Scissors_vs_Scissors_Draw()
        {
            new Game().PlayRound(Gesture_NEW.Scissors, Gesture_NEW.Scissors).Should().Be(Draw);
        }
    }
}
