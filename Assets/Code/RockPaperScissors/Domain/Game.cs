using static RockPaperScissors.Domain.Game.Result;

namespace RockPaperScissors.Domain
{
    public class Game
    {
        public Result PlayRound(Gesture_NEW player1Gesture, Gesture_NEW player2Gesture)
        {
            if(player1Gesture.Beats(player2Gesture))
                return Player1Win;
            else if(player2Gesture.Beats(player1Gesture))
                return Player2Win;
            else return Draw;
        }

        public enum Result
        {
            None,
            Player1Win,
            Player2Win,
            Draw
        }
    }
}