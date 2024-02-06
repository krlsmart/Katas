using System;

namespace TradingCards.Domain
{
    public record Player
    {
        public int Health { get; private set; }
        public int CurrentMana { get; }

        public Player()
        {
            Health = 30;
            CurrentMana = 0;
        }

        public void ReceiveDamage(int value)
        {
            Health -= value;
        }
    }
}
