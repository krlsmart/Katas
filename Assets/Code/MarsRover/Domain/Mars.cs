namespace MarsRover.Domain
{
    public readonly struct Mars
    {
        public readonly int MaxX { get; }
        public readonly int MaxY { get; }

        public Mars(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
        }
    }
}
