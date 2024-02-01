namespace RockPaperScissors.Domain
{
    public record Gesture_NEW
    {
        readonly string code;

        Gesture_NEW(string code)
            => this.code = code;

        public static Gesture_NEW Rock => new("Rock");
        public static Gesture_NEW Paper => new("Paper");
        public static Gesture_NEW Scissors => new("Scissors");
    }
}
