namespace MarsRover.Domain
{
    public record Position
    {
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
