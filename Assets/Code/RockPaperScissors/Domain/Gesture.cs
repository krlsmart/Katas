namespace RockPaperScissors.Domain
{
    public record Gesture
    {
        readonly string code;

        Gesture(string code)
            => this.code = code;

        public static Gesture Rock => new("Rock");
        public static Gesture Paper => new("Paper");
        public static Gesture Scissors => new("Scissors");
    }
}
