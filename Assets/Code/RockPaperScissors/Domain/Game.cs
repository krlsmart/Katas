using System;

namespace RockPaperScissors.Domain
{
    public class Game
    {
        public Gesture Play(Gesture firstGesture, Gesture secondGesture)
        {
            if(firstGesture.Equals(Gesture.Rock()) && secondGesture.Equals(Gesture.Scissors()))
                return Gesture.Rock();

            throw new ArgumentException();
        }
    }
}