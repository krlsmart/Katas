using System;

namespace MarsRover.Domain
{
    public class Order : IEquatable<Order>
    {
        readonly string code;

        Order(string code)
        {
            this.code = code;
        }

        public static Order TurnLeft = new("L");
        public static Order TurnRight = new("R");
        public static Order Move = new("M");

        public static Order By(string code)
        {
            if(!IsValid(code))
                throw new NotSupportedException($"The order with code {code} is not supported.");

            return new Order(code);
        }

        static bool IsValid(string order)
        {
            if (string.IsNullOrEmpty(order))
                return false;

            return order.Equals("L")
                || order.Equals("R")
                || order.Equals("M");
        }

        public bool Equals(Order other)
        {
            return this.code.Equals(other.code);
        }
    }
}
