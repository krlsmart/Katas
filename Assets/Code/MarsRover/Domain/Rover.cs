namespace MarsRover.Domain
{
    public class Rover
    {
        public int X { get; }
        public int Y { get; private set; }
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
            else if(order == "R")
                TurnRight();
            else if(order == "M")
                Move();
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

        private void TurnRight()
        {
            switch (LookingAt)
            {
                case Cardinal.N:
                    LookingAt = Cardinal.E; break;
                case Cardinal.W:
                    LookingAt = Cardinal.N; break;
                case Cardinal.S:
                    LookingAt = Cardinal.W; break;
                case Cardinal.E:
                    LookingAt = Cardinal.S; break;
            }
        }

        private void Move()
        {
            switch(LookingAt)
            {
                case Cardinal.N:
                    Y += 1; break;
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
