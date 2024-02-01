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
            new Game().PlayRound(Gesture_NEW.Rock, Gesture_NEW.Scissors).Should().Be(Player1Win);
        }

        [Test]
        public void Rock_vs_Paper_RockLose()
        {
            new Game().PlayRound(Gesture_NEW.Rock, Gesture_NEW.Paper).Should().Be(Player2Win);
        }

        [Test]
        public void Rock_vs_Rock_Draw()
        {
            new Game().PlayRound(Gesture_NEW.Rock, Gesture_NEW.Rock).Should().Be(Draw);
        }
    }
}
