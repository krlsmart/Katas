using System;
using static RockPaperScissors.Domain.Game.Result;

namespace RockPaperScissors.Domain
{
    public class Game
    {
        public Result PlayRound(Gesture someGesture, Gesture otherGesture)
        {
            if(someGesture.Beats(otherGesture))
                return Player1Win;
            else
                return Player2Win;

            throw new ArgumentException();
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