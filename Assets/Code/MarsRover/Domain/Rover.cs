namespace MarsRover.Domain
{
    public class Rover
    {
        public int X { get; }
        public int Y { get; }
        public Cardinal LookingAt { get; private set; }

        public Rover(int x, int y, Cardinal lookingAt)
        {
            X = x;
            Y = y;
            LookingAt = lookingAt;
        }

        public void Execute(string order)
        {
            if (order == "L")
                TurnLeft();
        }

        private void TurnLeft()
        {
            switch(LookingAt)
            {
                case Cardinal.N:
                    LookingAt = Cardinal.W; break;
                case Cardinal.W:
                    LookingAt = Cardinal.S; break;
                case Cardinal.S:
                    LookingAt = Cardinal.E; break;
                case Cardinal.E:
                    LookingAt = Cardinal.N; break;
            }
        }
    }

    public enum Cardinal
    {
        N,
        W,
        E,
        S
    }
}
