namespace MarsRover.Domain
{
    public class Rover
    {
        public int X { get; }
        public int Y { get; }
        public Cardinal Facing { get; private set; }

        public Rover(int v1, int v2, Cardinal v3)
        {
            X = v1;
            Y = v2;
            Facing = v3;
        }

        public void Execute(string order)
        {
            if (order == "L")
                TurnLeft();
        }

        private void TurnLeft()
        {
            switch(Facing)
            {
                case Cardinal.N:
                    Facing = Cardinal.W; break;
                case Cardinal.W:
                    Facing = Cardinal.S; break;
                case Cardinal.S:
                    Facing = Cardinal.E; break;
                case Cardinal.E:
                    Facing = Cardinal.N; break;
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
