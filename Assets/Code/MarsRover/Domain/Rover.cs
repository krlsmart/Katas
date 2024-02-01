namespace MarsRover.Domain
{
    public class Rover
    {
        public Position Position { get; private set; }
        readonly Mars mars;
        

        public Rover(Position startingPosition, Mars mars)
        {
            if (!mars.IsValidPosition(startingPosition.X, startingPosition.Y))
                throw new System.ArgumentException("Rover is being created out of Mars");

            Position = startingPosition;
            this.mars = mars;
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
            Position targetPosition = null;
            switch(Position.LookingAt)
            {
                case Cardinal.N:
                    targetPosition = Position with { Y = Position.Y + 1}; break;
                case Cardinal.W:
                    targetPosition = Position with { X = Position.X - 1 }; break;
                case Cardinal.S:
                    targetPosition = Position with { Y = Position.Y - 1 }; break;
                case Cardinal.E:
                    targetPosition = Position with { X = Position.X + 1 }; break;
                default:
                    throw new System.ArgumentOutOfRangeException();
            }

            if(mars.IsValidPosition(targetPosition.X, targetPosition.Y))
                Position = targetPosition;
        }
    }
}
