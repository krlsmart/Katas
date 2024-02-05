namespace RockPaperScissors.Domain
{
    public static class GesturesFactory
    {
        public static Gesture Rock => new Rock();
        public static Gesture Scissors => new Scissors();
        public static Gesture Paper => new Paper();
        public static Gesture Lizard => new Lizard();
        public static Gesture Spock => new Spock();
    }
}
