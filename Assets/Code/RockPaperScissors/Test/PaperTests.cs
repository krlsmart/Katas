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
            new Game().PlayRound(Gesture_NEW.Paper, Gesture_NEW.Rock).Should().Be(Player1Win);
        }

        [Test]
        public void Paper_vs_Scissors_PaperLose()
        {
            new Game().PlayRound(Gesture_NEW.Paper, Gesture_NEW.Scissors).Should().Be(Player2Win);
        }

        [Test]
        public void Paper_vs_Paper_Draw()
        {
            new Game().PlayRound(Gesture_NEW.Paper, Gesture_NEW.Paper).Should().Be(Draw);
        }
    }
}
