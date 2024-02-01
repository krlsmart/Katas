using System.Linq;

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

        public void Execute(string input)
        {
            var orders = Parser.Split(input);
            foreach(var order in orders.Select(Order.By))
                ExecuteSingleOrder(order);
        }

        void ExecuteSingleOrder(Order order)
        {
            if(order.Equals(Order.TurnLeft))
                TurnLeft();
            if(order.Equals(Order.TurnRight))
                TurnRight();
            if(order.Equals(Order.Move))
                Move();
        }

        void TurnLeft()
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

        void TurnRight()
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

        void Move()
        {
            var targetPosition = Position.LookingAt switch
            {
                Cardinal.N => Position with { Y = Position.Y + 1 },
                Cardinal.W => Position with { X = Position.X - 1 },
                Cardinal.S => Position with { Y = Position.Y - 1 },
                Cardinal.E => Position with { X = Position.X + 1 },
                _ => throw new System.ArgumentOutOfRangeException(),
            };

            if (mars.IsValidPosition(targetPosition.X, targetPosition.Y))
                Position = targetPosition;
        }
    }
}
