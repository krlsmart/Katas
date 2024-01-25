namespace RockPaperScissors.Domain
{
    public readonly struct Gesture
    {
        private readonly string id;

        Gesture(string id)
        {
            this.id = id;
        }

        public static Gesture Rock() => new("Rock");
        public static Gesture Paper() => new("Paper");
        public static Gesture Scissors() => new("Scissors");

        public bool Beats(Gesture other)
        {
            if(this.Equals(Rock()) && other.Equals(Scissors()))
                return true;

            return false;
        }
    }
}
