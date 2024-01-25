using System;
using static RockPaperScissors.Domain.Gesture;
using static RockPaperScissors.Domain.Game.Result;

namespace RockPaperScissors.Domain
{
    public class Game
    {
        public Result PlayRound(Gesture someGesture, Gesture otherGesture)
        {
            if(someGesture.Equals(Rock()) && otherGesture.Equals(Scissors()))
                return Player1Win;

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