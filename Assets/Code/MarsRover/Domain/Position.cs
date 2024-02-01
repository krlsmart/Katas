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

        public int X { get; init; } = 0;
        public int Y { get; init; } = 0;
        public Cardinal LookingAt { get; init; } = Cardinal.N;
    }

    public enum Cardinal
    {
        N,
        W,
        E,
        S
    }
}
