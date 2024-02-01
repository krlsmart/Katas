namespace RockPaperScissors.Domain
{
    public static class GameRules
    {
        public static bool Beats(this Gesture_NEW gesture, Gesture_NEW other)
        {
            if(gesture.Equals(Gesture_NEW.Rock) && other.Equals(Gesture_NEW.Scissors))
                return true;

            if (gesture.Equals(Gesture_NEW.Paper) && other.Equals(Gesture_NEW.Rock))
                return true;

            if (gesture.Equals(Gesture_NEW.Scissors) && other.Equals(Gesture_NEW.Paper))
                return true;

            return false;
        }
    }
}
