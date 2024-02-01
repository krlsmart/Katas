namespace MarsRover.Domain
{
    public class Rover
    {
        public Position Position { get; private set; }
        

        public Rover(Position startingPosition)
        {
            Position = startingPosition;
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
            switch(Position.LookingAt)
            {
                case Cardinal.N:
                    Position = Position with { LookingAt = Cardinal.W }; break;
                case Cardinal.W:
                    Position = Position with { LookingAt = Cardinal.S }; break;
                case Cardinal.S:
                    Position = Position with { LookingAt = Cardinal.E }; break;
                case Cardinal.E:
                    Position = Position with { LookingAt = Cardinal.N }; break;
            }
        }

        private void TurnRight()
        {
            switch (Position.LookingAt)
            {
                case Cardinal.N:
                    Position = Position with { LookingAt = Cardinal.E }; break;
                case Cardinal.W:
                    Position = Position with { LookingAt = Cardinal.N }; break;
                case Cardinal.S:
                    Position = Position with { LookingAt = Cardinal.W }; break;
                case Cardinal.E:
                    Position = Position with { LookingAt = Cardinal.S }; break;
            }
        }

        private void Move()
        {
            switch(Position.LookingAt)
            {
                case Cardinal.N:
                    Position = Position with { Y = Position.Y + 1}; break;
                case Cardinal.W:
                    Position = Position with { X = Position.X - 1 }; break;
                case Cardinal.S:
                    Position = Position with { Y = Position.Y - 1 }; break;
                case Cardinal.E:
                    Position = Position with { X = Position.X + 1 }; break;
            }
        }
    }
}
