namespace RockPaperScissors.Domain
{
    public interface Gesture
    {
        public bool Beats(Gesture other);
    }

    public readonly struct Rock : Gesture
    {
        public bool Beats(Gesture other)
            => other is Scissors or Lizard;
    }

    public readonly struct Paper : Gesture
    {
        public bool Beats(Gesture other)
            => other is Rock or Spock;
    }

    public readonly struct Scissors : Gesture
    {
        public bool Beats(Gesture other)
            => other is Paper or Lizard;
    }

    public readonly struct Lizard : Gesture
    {
        public bool Beats(Gesture other)
            => other is Paper or Spock;
    }

    public readonly struct Spock : Gesture
    {
        public bool Beats(Gesture other)
            => other is Rock or Scissors;
    }
}
