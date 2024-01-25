namespace RockPaperScissors.Domain
{
    public abstract class Gesture
    {
        public abstract bool Beats(Gesture other);
    }

    public class Rock : Gesture
    {
        public override bool Beats(Gesture other)
        {
            return other is Scissors;
        }
    }

    public class Scissors : Gesture
    {
        public override bool Beats(Gesture other)
        {
            return other is Paper;
        }
    }

    public class Paper : Gesture
    {
        public override bool Beats(Gesture other)
        {
            return other is Rock;
        }
    }
}
