using static RockPaperScissors.Domain.Gesture;

namespace RockPaperScissors.Domain
{
    public static class GameRules
    {
        public static bool Beats(this Gesture gesture, Gesture other)
        {
            if(gesture.Equals(Rock) && other.Equals(Scissors))
                return true;

            if(gesture.Equals(Rock) && other.Equals(Lizard))
                return true;

            if(gesture.Equals(Paper) && other.Equals(Rock))
                return true;

            if(gesture.Equals(Scissors) && other.Equals(Paper))
                return true;

            if(gesture.Equals(Scissors) && other.Equals(Lizard))
                return true;

            if(gesture.Equals(Lizard) && other.Equals(Paper))
                return true;

            return false;
        }
    }
}
