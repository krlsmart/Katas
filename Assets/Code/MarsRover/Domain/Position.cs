namespace MarsRover.Domain
{
    public record Position
    {
        public Position(int x, int y, Cardinal lookingAt)
        {
            X = x;
            Y = y;
            LookingAt = lookingAt;
        }

        public int X { get; init; }
        public int Y { get; init; }
        public Cardinal LookingAt { get; init; }

        public static Position Zero => new(0, 0, Cardinal.N);
    }

    public enum Cardinal
    {
        N,
        W,
        E,
        S
    }
}
