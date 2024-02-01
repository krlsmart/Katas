namespace MarsRover.Domain
{
    public readonly struct Mars
    {
        const int MinX = 0;
        const int MinY = 0;
        public readonly int MaxX { get; }
        public readonly int MaxY { get; }

        public Mars(int maxX, int maxY)
        {
            MaxX = maxX;
            MaxY = maxY;
        }

        public bool IsValidPosition(int x, int y)
        {
            return x >= MinX
                && x <= MaxX
                && y >= MinY
                && y <= MaxY;
        }
    }
}
