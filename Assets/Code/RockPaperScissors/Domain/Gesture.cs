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
    }
}
